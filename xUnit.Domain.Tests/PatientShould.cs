using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xUnit.Domain.Tests
{
    public class PatientShould
    {
        [Fact]
        public void PatientIsNew()
        {
            var patient = new Patient();

            Assert.True(patient.IsNew);
        }
    }
}
