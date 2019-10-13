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

        [Fact]
        public void CalculateFullName()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.Equal("Nick Carter", p.FullName);
        }

        [Fact]
        public void CalculateFullNameStartsWithFirstName()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.StartsWith("Nick", p.FullName);
        }

        [Fact]
        public void CalculateFullNameEndsWithFirstName()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.EndsWith("Carter", p.FullName);
        }

        [Fact]
        public void PatientFullNameIgnoreCase()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };

            Assert.Equal("NICK CARTER", p.FullName, true);
        }
    }
}
