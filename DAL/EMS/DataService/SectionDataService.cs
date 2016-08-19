using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace DAL.EMS.DataService
{
  public class SectionDataService
    {
        CommonConnection connection=new CommonConnection();
        public string SectionDataSave(SectionEntity objSection)
        {
            string rv = "";
            string query;
            //CommonConnecti
            try
            {
                string condition;
                if (objSection.SectionId == 0)
                {
                    condition = string.Format(@"Where Name='{0}'",objSection.Name);
                }
                else
                {
                    condition = string.Format(@" Where Name='{0}' And SectionId !={1}", objSection.Name, objSection.SectionId);
                }

                var res = GetExistSectionName(condition);
                if (res > 0)
                {
                    return Operation.Exists.ToString();
                }

                if (objSection.SectionId == 0)
                {
                    query = string.Format(@"Insert Into SectionInfo (Name, Description, IsActive) 
                Values('{0}','{1}', {2})", objSection.Name, objSection.Description, objSection.IsActive);
                }
                else
                {
                    query = string.Format(@"Update SectionInfo Set Name='{0}', Description='{1}', IsActive={2} 
                                            Where SectionId={3}", objSection.Name, objSection.Description, objSection.IsActive, objSection.SectionId);
                }
                connection.ExecuteNonQuery(query);
                rv = Operation.Success.ToString();
            }
            catch (Exception exception)
            {
                rv = exception.Message;
            }
            return rv;
        }

      private int GetExistSectionName(string condition)
      {
            try
            {
                string sql = string.Format(@"Select * From SectionInfo {0}", condition);
                var data = Data<SubjectEntity>.DataSource(sql);
                return data.Count;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
      

        public GridEntity<SectionEntity> GetGridData(GridOptions options)
      {
            string sql = "Select * From SectionInfo";
            var data = Kendo<SectionEntity>.Grid.DataSource(options, sql, "SectionId DESC");
            return data;
        }
    }
}
