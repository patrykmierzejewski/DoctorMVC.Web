using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorMVC.Application.Interfaces
{
    public interface IItemService
    {
        List<int> GetAllItems();
    }
}
