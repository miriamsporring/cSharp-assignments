namespace ChoirApplication.Tests.UnitTests;

public class FileService_UnitTest
{
    [Fact]
    public void Should_ReadFromFile_WhenFileDoesNotExist_AndReturnNull()
    {
        //Arrange
        fileService = new FileService();

        //Act
        string result = fileService.ReadFromFile(fakeFilePath);


        //Assert
        Assert.Null(result);



    }


}
