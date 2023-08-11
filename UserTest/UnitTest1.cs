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
            string result = "";
            if (userReg.ValidateFirstName("Name"))
            {
                result = "HAPPY";
            }
            else
            {
                result = "SAD";
            }
            Assert.AreEqual(result, "HAPPY");

            if (userReg.ValidateFirstName("name"))
            {
                result = "HAPPY";
            }
            else
            {
                result = "SAD";
            }
            Assert.AreEqual(result, "SAD");
        }
        [Test]
        public void TestLastName()
        {
            User userReg = new User();
            string result = "";
            if(userReg.ValidateLastName("Name")) { 
                result = "HAPPY";
            }
            else { 
                result = "SAD"; 
            }
            Assert.AreEqual(result,"HAPPY");

            if (userReg.ValidateLastName("name"))
            {
                result = "HAPPY";
            }
            else
            {
                result = "SAD";
            }
            Assert.AreEqual(result, "SAD");
        }
        [Test]
        public void TestMobile()
        { 
            User userReg = new User();
            string result = "";
            if (userReg.ValidatePhonenumber("91 8789653465"))
            {
                result = "HAPPY";
            }
            else
            {
                result = "SAD";
            }
            Assert.AreEqual(result, "HAPPY");

            if (userReg.ValidatePhonenumber("76 876877"))
            {
                result = "HAPPY";
            }
            else
            {
                result = "SAD";
            }
            Assert.AreEqual(result, "SAD");
        }
        [Test]
        public void TestEmail()
        {
            User userReg = new User();
            string result = "";
            if (userReg.ValidateEmail("abc.uh@huasd.com.in"))
            {
                result = "HAPPY";
            }
            else
            {
                result = "SAD";
            }
            Assert.AreEqual(result, "HAPPY");

            if (userReg.ValidateEmail("abc@.uyagd.col"))
            {
                result = "HAPPY";
            }
            else
            {
                result = "SAD";
            }
            Assert.AreEqual(result, "SAD");
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
            string result = "";
            if (userReg.ValidatePassword("Naren@12345"))
            {
                result = "HAPPY";
            }
            else
            {
                result = "SAD";
            }
            Assert.AreEqual(result, "HAPPY");

            if (userReg.ValidatePassword("vuvcuy0SDc"))
            {
                result = "HAPPY";
            }
            else
            {
                result = "SAD";
            }
            Assert.AreEqual(result, "SAD");
        }
    }
}