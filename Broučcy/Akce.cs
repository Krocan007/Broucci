using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broucy
{
    abstract class Akce
    {
        abstract public void UpravBroucka(Brouk brouk);
    }
    class OtocDoprava : Akce
    {
        public override void UpravBroucka(Brouk brouk)
        {
            throw new NotImplementedException();
        }
    }
    class OtocDoleva : Akce
    {
        public override void UpravBroucka(Brouk brouk)
        {
            throw new NotImplementedException();
        }
    }
    class Jdi : Akce
    {
        public override void UpravBroucka(Brouk brouk)
        {
            throw new NotImplementedException();
        }
    }
}
