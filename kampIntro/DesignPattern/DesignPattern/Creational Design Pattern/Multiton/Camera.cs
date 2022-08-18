using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Multiton
{
    public  class Camera
    {
        static Dictionary<string, Camera> Cameras = new Dictionary<string, Camera>();
        static object _lock=new object();
        string brand;
        public Guid Id { get; set; }
        public Camera()
        {
           Id = Guid.NewGuid();
        }
        public static Camera GetCamera(string brand)
        {
            lock(_lock)
            {
                if (!Cameras.ContainsKey(brand))
                {
                    Cameras.Add(brand, new Camera());
                }
            }
            return Cameras[brand];
        }
    }
   
}
