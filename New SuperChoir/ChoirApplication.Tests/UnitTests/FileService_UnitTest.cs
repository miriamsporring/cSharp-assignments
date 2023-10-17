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

        string result = FileService.ReadFromFile(filePath); //behöver funktion i FileService


        //Assert
        Assert.Null(result);


    }

}
