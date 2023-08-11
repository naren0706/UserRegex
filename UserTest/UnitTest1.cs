using UserRegex;

namespace UserTest
{
    public class Tests
    {
        static string TrueEmailFilePath = @"E:\BridgeGateProblems\UserRegex\UserTest\TrueEmail.txt";
        static string FalseEmailFilePath = @"E:\BridgeGateProblems\UserRegex\UserTest\FalseEmail.txt";
        [Test]
        public void TestFirstName()
        {
            User userReg = new User();
            bool valid = userReg.ValidateFirstName("Naren");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidateFirstName("naren");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestLastName()
        {
            User userReg = new User();
            bool valid = userReg.ValidateLastName("Name");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidateLastName("yuvuy878");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestMobile()
        {
            User userReg = new User();
            bool valid = userReg.ValidatePhonenumber("91 8789653465");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidatePhonenumber("76 876877");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestEmail()
        {
            User userReg = new User();
            bool valid = userReg.ValidateEmail("abc.uh@huasd.com.in");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidateEmail("abc@.uyagd.col");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestAllTrueEmail()
        {
            string[] TrueEmails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            User userReg = new User();
            foreach (var item in TrueEmails)
            {
                bool res = userReg.ValidateEmail(item);
                Assert.IsTrue(res);
            }
        }
        [Test]
        public void TestAllFalseEmail()
        {
            string[] FalseEmail = File.ReadAllText(FalseEmailFilePath).Split(',');
            User userReg = new User();
            foreach (var item in FalseEmail)
            {
                bool res = userReg.ValidateEmail(item);
                Assert.IsFalse(res);
            }
        }
        [Test]
        public void TestPassword()
        {
            User userReg = new User();
            bool valid = userReg.ValidatePassword("Naren@12345");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidatePassword("vuvcuy0SDc");
            Assert.IsFalse(invalid);
        }
    }
}