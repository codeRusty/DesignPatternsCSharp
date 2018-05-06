using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class MachineBuilder :ICloneable<MachineBuilder>
    {
        StringBuilder systemImage;

        private MachineBuilder(string image)
        {
            systemImage = new StringBuilder(image);
        }

        public MachineBuilder(string processor,string OS) {
            systemImage = new StringBuilder();
            systemImage.AppendLine(processor);
            systemImage.AppendLine(OS);
        }

        public void install(string app) {
            systemImage.AppendLine(app);
        }
        public void Boot()
        {
            Console.WriteLine(systemImage.ToString());
        }

        // should deep copy the image 
        public MachineBuilder Clone()
        {
            return new MachineBuilder(systemImage.ToString());
        }
    }
}
