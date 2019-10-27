using System;
using Xunit;


namespace HarryPotterTests
{
    public class BookstoreTests
    {
       [Fact]
       public void TestName()
       {
       //Given
       var bookstore = new Bookstore();
       //When
       decimal cost = bookstore.checkout();
       //Then
       Assert.Equal(8m, cost);
       }

    }
    
}