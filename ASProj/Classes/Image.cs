using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Classes
{
    public class Image
    {
        // DA 10/7/22 Constructor
        [JsonConstructor]
        public Image(Guid Id, byte[] Blob, DateTime CreatedAt)
        {
            this.Id = Id;
            this.Blob = Blob;
            this.CreatedAt = CreatedAt;
        }
        public Image(byte[] blob) // DA 10/7/22 Construct from byte array
        {
            Id = Guid.NewGuid();
            Blob = blob;
            CreatedAt = DateTime.Now;
        }
        public Image(Bitmap bm) // DA 10/7/22 Construct from bitmap (directly from PictureBox)
        {
            using (var stream = new MemoryStream())
            {
                bm.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);

                // DA 10/7/22 Now assign the properties of the new object
                Blob = stream.ToArray();
                Id = Guid.NewGuid();
                CreatedAt = DateTime.Now;
            }
        }
        public Image(string filepath) // DA 10/7/22 Construct from a file
        {
            FileStream fs = File.OpenRead(filepath);
            byte[] blob = new byte[fs.Length];
            fs.Read(blob, 0, Convert.ToInt32(fs.Length));

            // DA 10/7/22 Now assign the properties of the new object
            Blob = blob;
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;

            // DA 10/7/22 Clean up
            fs.Dispose();
        }

        // DA 10/7/22 Properties
        public byte[] Blob { get; }
        public Guid Id { get; }
        public DateTime CreatedAt { get; }

        // DA 10/7/22 Saving Method
        public void Save()
        {
            FileHandler.Update<Image>("images.json", Id.ToString(), Image.Serialize(this));
        }

        // DA 10/7/22 Conversion methods
        public Bitmap ToBitmap()
        {
            MemoryStream ms = new MemoryStream();
            byte[] d = Blob;
            ms.Write(d, 0, Convert.ToInt32(d.Length));
            Bitmap bm = new Bitmap(ms, false);
            ms.Dispose();
            return bm;
        }

        // DA 10/7/22 Serialization (static - must be accessed by the class directly i.e. Image.Serialize())
        public static string Serialize(Image obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static string Serialize(List<Image> obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static List<Image> Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<List<Image>>(json);
        }

        // DA 10/7/22 "Database" searching methods
        public static Image Search(Guid Id)
        {
            string file = FileHandler.Select("images.json");
            List<Image> images = Deserialize(file);
            if (images == null) images = new List<Image>();
            foreach (Image im in images) {
                if (im.Id == Id) return im;
            }
            throw new Exception("That image cannot be found in the database.");
        }
    }
}
