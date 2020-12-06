using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCorses1.Models
{
    public class Application
    {
        private string name;
        private string imgPath;
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ImgPath
        {
            get { return imgPath; }
            set { imgPath = value; }
        }

        public Application()
        {
        }
    }
}
