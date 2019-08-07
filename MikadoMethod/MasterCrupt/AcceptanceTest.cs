using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MasterCrupt
{
    [TestFixture]
    public class AcceptanceTest
    {
        [Test]
        public void TestSecret()
        {
            UI ui = new UI();
            Assert.AreEqual("Leeted: S3cr3t", ui.EncryptMessage("Secret"));
        }
    }
}
