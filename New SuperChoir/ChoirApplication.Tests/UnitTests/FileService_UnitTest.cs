using ChoirApplication.Services;
using Xunit;

namespace ChoirApplication.Tests.UnitTests;

//det här enhetstestet ska läsa från filen, om filen inte finns, return null
public class FileService_UnitTest 
{

    [Fact]
    public void ShouldReadFromFile_AndReturnNull_WhenFileDoesNotExist()

    {
        
        //Arrange - förbereda testet
        FileService fileService = new FileService();
        string filePath = "fakefile.txt";


        //Act - utför testet
        //behöver funktion i FileService för att testet ska godkännas
        string result = FileService.ReadFromFile(filePath); 


        //Assert - returnera null
        Assert.Null(result);


    }

}
