using HowToFileUploads.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace HowToFileUploads.Controllers
{
    public class HomeController : Controller
    {
        private IWebHostEnvironment _env;
        private string _dir;
        private Jelovnik jelovnik = new Jelovnik();



        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
            _dir = _env.ContentRootPath;
        }

        public IActionResult Index() => View();

        public IActionResult SingleFile(IFormFile file)
        {
            using (var fileStream = new FileStream(Path.Combine(_dir, "in.xml"), FileMode.Create, FileAccess.Write))
            {
                file.CopyTo(fileStream);
            }

            parseXML(file);

            //Generiranje QR koda
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("Prvi obrok je: " + jelovnik.Obroci[0].Naziv, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            var bitmapBytes = BitmapToBytes(qrCodeImage);

            //Isto kao sto bi se inace vratio View, na ovaj nacin pretrazivac izbaci sirovi file(u ovom slucaju QR kod)
            return File(bitmapBytes, "image/jpeg");
            //return RedirectToAction("Index");
        }

        private void parseXML(IFormFile file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file.FileName);




            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/jelovnik/obrok");

            var enumerator = nodes.GetEnumerator();

            jelovnik.Obroci = new List<Obrok>();
            foreach (XmlNode node in nodes)
            {
                Obrok o = new Obrok();
                o.Naziv = node.SelectSingleNode("naziv").InnerText;
                o.Cijena = int.Parse(node.SelectSingleNode("cijena").InnerText);
                jelovnik.Obroci.Add(o);
            }
        }

        //Ovom metodom se bitmap pretvara u byte array
        private static byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}