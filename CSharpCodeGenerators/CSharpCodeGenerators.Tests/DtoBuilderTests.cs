using System;
using System.IO;
using Xunit;
using FluentAssertions;

namespace CSharpCodeGenerators
{
    public class DtoBuilderTests
    {
        [Fact]
        public void GetBuilder_Candy_IsEqual()
        {
            var expected = ArrangeCandyBuilder();
            
            var actual = DtoBuilder<Candy>.GetBuilder();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestBuilder()
        {
            var expected = new Candy(5, 27);
            
            var result = Candy.Build()
                .WithChocolate(5)
                .WithMarshmallow(27)
                .Build();

            result.Should().BeEquivalentTo(expected);
        }
        
        [Fact]
        public void TestBuilder2()
        {
            var expected = new Candy(5, 27);
            
            var result = new Candy.Builder()
                .WithChocolate(5)
                .WithMarshmallow(27)
                .Build();

            result.Should().BeEquivalentTo(expected);
        }
        
        [Fact]
        public void TestBuilder3()
        {
            var expected = new Candy(5, 27);
            
            var result = new Candy.Builder()
            {
                Chocolate = 5, 
                Marshmallow = 27
            }.Build();

            result.Should().BeEquivalentTo(expected);
        }
        
        [Fact]
        public void TestBuilder4()
        {
            var expected = new Candy(5, 27);
            
            var result = new CandyBuilder()
            {
                Chocolate = 5, 
                Marshmallow = 27
            }.Build();

            result.Should().BeEquivalentTo(expected);
        }

        private string ArrangeCandyBuilder()
        {
            string result;
            
            using(var reader = new StreamReader("CandyBuilder.cs"))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }
    }
}
