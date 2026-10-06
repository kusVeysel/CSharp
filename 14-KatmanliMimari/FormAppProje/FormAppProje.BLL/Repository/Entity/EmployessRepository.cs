using FormAppProje.BLL.DTO;
using FormAppProje.BLL.Repository.Base;
using FormAppProje.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FormAppProje.BLL.Repository.Entity
{
    public class EmployessRepository : BaseRepository<Employees>
    {
        public List<CalisanDTO> CalisanOzetGetir()
        {
            List<CalisanDTO> dtoList = new List<CalisanDTO>();

            List<Employees> employeesList = this.GetAll2();

            foreach (Employees emp in employeesList)
            {
                CalisanDTO dto = new CalisanDTO();
                dto.ID = emp.EmployeeID;
                dto.CalisanAdSoyad = emp.FirstName + " " + emp.LastName;
                dto.Yas = (DateTime.Now.Year - emp.BirthDate.Value.Year).ToString();
                dto.CalismaSuresi = (DateTime.Now.Year - emp.HireDate.Value.Year) + " Yıl".ToString();

                dtoList.Add(dto);
            }

            return dtoList.Distinct().ToList();
        }
    }
}
