using ChoirApplication.Services;
using Xunit;

namespace ChoirApplication.Tests.UnitTests;

public class FileService_UnitTest
{

    [Fact]
    public void ShouldReadFromFile_AndReturnNull_WhenFileDoesNotExist()

    {
        
        //Arrange
        FileService fileService = new FileService();
        string filePath = "fakefile.txt";


        //Act
        IEnumerable<string> result = ReadFromFile(filePath);


        //Assert
        Assert.Null(result);


    }


   
}
