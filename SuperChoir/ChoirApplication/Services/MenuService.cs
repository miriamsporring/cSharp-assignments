using ChoirApplication.Interfaces;
using ChoirApplication.Models;

namespace ChoirApplication.Services;


internal interface IMenuService
{
    public void MainMenu();
    public void CreateMenu();
    public void ListAllMenu();
    public void ListSpecificMenu();

}

internal class MenuService : IMenuService
{
    public void CreateMenu()
    {
        throw new NotImplementedException();
    }

    public void ListAllMenu()
    {
        throw new NotImplementedException();
    }

    public void ListSpecificMenu()
    {
        throw new NotImplementedException();
    }

    public void MainMenu()
    {
        throw new NotImplementedException();
    }
}


