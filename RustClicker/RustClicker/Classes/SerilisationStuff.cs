﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RustClicker.Classes
{
    public class SerilisationStuff
    {

        public BaseClass XMLDeserialiserWS()
        {
            try
            {
                //ChatGPT yi daha yeni keşfettim :(

                string documentsPath1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string folderPath2 = Path.Combine(documentsPath1, "Rust_Clicker");

                if (!Directory.Exists(folderPath2))
                {
                    Directory.CreateDirectory(folderPath2);
                }

                string filePath2 = Path.Combine(folderPath2, "Save.txt");
                bool a = true;
                if (!File.Exists(filePath2))
                {
                    a = false;
                    File.Create(filePath2);
                    return null;
                }

                //DirectoryInfo di = new DirectoryInfo(@"C:\Program Files\AnInterestingDesktopAppName");
                //if (!di.Exists)
                //{
                //    di.Create();
                //}
                //FileInfo fid = new FileInfo(@"C:\Program Files\AnInterestingDesktopAppName/Data.txt");
                //if (!fid.Exists)
                //{
                //    fid.Create();
                //}

                if (a)
                {
                    string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string dataFilePath = Path.Combine(documentsPath, "Rust_Clicker", "Save.txt");

                    StreamReader sr = new StreamReader(dataFilePath);
                    using (var stringReader = new StringReader(sr.ReadToEnd()))
                    {
                        var serializer = new XmlSerializer(typeof(BaseClass));
                        return (BaseClass)serializer.Deserialize(stringReader);
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save(BaseClass saveableThing)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string folderPath = Path.Combine(documentsPath, "Rust_Clicker");

            string dataFilePath = Path.Combine(folderPath, "Save.txt");

            using (StreamWriter sw = new StreamWriter(dataFilePath, false))
            {
                sw.Write(XMLSerialize(saveableThing));
            }

            Statics.db = saveableThing;
        }

        public string XMLSerialize(BaseClass thingToSerialize)
        {
            try
            {
                var stringWriter = new StringWriter();
                var serializer = new XmlSerializer(typeof(BaseClass));
                serializer.Serialize(stringWriter, thingToSerialize);
                return stringWriter.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BaseClass XMLDeseriliazier(string xmlData)
        {
            try
            {
                var stringReader = new StringReader(xmlData);
                var serializer = new XmlSerializer(typeof(BaseClass));
                return (BaseClass)serializer.Deserialize(stringReader);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}