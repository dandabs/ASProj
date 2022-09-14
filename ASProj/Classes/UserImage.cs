using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASProj.Utils;
using System.Drawing;
using System.IO;

namespace ASProj.Classes
{
    public class UserImage
    {
        // DA 10/7/22 Constructor
        [JsonConstructor]
        public UserImage(Guid Id, byte[] Blob, DateTime CreatedAt)
        {
            this.Id = Id;
            this.Blob = Blob;
            this.CreatedAt = CreatedAt;
        }
        public UserImage(byte[] blob) // DA 10/7/22 Construct from byte array
        {
            Id = Guid.NewGuid();
            Blob = blob;
            CreatedAt = DateTime.Now;
        }
        public UserImage(Bitmap bm) // DA 10/7/22 Construct from bitmap (directly from PictureBox)
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
        public UserImage(string filepath) // DA 10/7/22 Construct from a file
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
            FileHandler.Update<UserImage>("images.json", Id.ToString(), UserImage.Serialize(this));
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
        public static string Serialize(UserImage obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static string Serialize(List<UserImage> obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static List<UserImage> Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<List<UserImage>>(json);
        }

        // DA 10/7/22 "Database" searching methods
        public static UserImage Search(Guid Id)
        {
            string file = FileHandler.Select("images.json");
            List<UserImage> images = Deserialize(file);
            if (images == null) images = new List<UserImage>();
            foreach (UserImage im in images) {
                if (im.Id == Id) return im;
            }
            throw new Exception("That image cannot be found in the database.");
        }
    }
}
