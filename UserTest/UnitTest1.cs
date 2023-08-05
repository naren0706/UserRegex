using UserRegex;

namespace UserTest
{
    public class Tests
    {
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
        public void TestPassword()
        {
            User userReg = new User();
            bool valid = userReg.ValidatePassword("vvdcA876@fsd");
            Assert.IsTrue(valid);
            bool invalid = userReg.ValidatePassword("vuvcuy0SDc");
            Assert.IsFalse(invalid);
        }
    }
}