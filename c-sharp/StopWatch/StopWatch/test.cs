using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    abstract class Hinh { }

    class Tron : Hinh { }

    abstract class DaGiac : Hinh { }

    class TamGiac : DaGiac { }

    class ChuNhat : DaGiac { }

    Hinh h1 = new Tron()

Hinh h2 = new TamGiac()

Hinh h3 = new ChuNhat()
}
