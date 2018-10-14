using Xunit;
using MARE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;

namespace MARE.Tests
{
    public class MareRegHandlerTests
    {
        private readonly IMessageBox MsgBoxFake;
        private readonly IRegistry RegFake;
        private readonly IRegistryKey RegKeyFake;

        public MareRegHandlerTests()
        {
            RegKeyFake = A.Fake<IRegistryKey>();
            A.CallTo(() => RegKeyFake.GetSubKeyNames()).Returns(new string[] { "Key" });


            RegFake = A.Fake<IRegistry>();
            A.CallTo(() => RegFake.OpenSubKey(A.Dummy<string>())).Returns(RegKeyFake);

            MsgBoxFake = A.Fake<IMessageBox>();
            A.CallTo(() => MsgBoxFake.Show(A.Dummy<string>())).DoesNothing();
        }

        [Fact]
        public void MareRegHandlerTest()
        {
            var oMareRegHandler = new MareRegHandler(RegFake, MsgBoxFake);
            Assert.Empty(oMareRegHandler.AllGFX);
        }

        [Fact]
        public void LoadRegTest()
        {
            var oMareRegHandler = new MareRegHandler(RegFake, MsgBoxFake);
            oMareRegHandler.LoadReg();


            A.CallTo(() => RegFake.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}")).MustHaveHappened();
        }

        [Fact]
        public void UpdateTest()
        {
           
        }

        [Fact]
        public void SaveRegTest()
        {
            var oMareRegHandler = new MareRegHandler(RegFake, MsgBoxFake);
            oMareRegHandler.SaveReg();

            A.CallTo(() => RegFake.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}")).MustHaveHappened();
        }
    }
}