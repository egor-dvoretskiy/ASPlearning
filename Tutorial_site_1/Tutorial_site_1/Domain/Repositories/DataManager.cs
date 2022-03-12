using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial_site_1.Domain.Repositories.Abstract;

namespace Tutorial_site_1.Domain.Repositories
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository)
        {
            this.TextFields = textFieldsRepository;
            this.ServiceItems = serviceItemsRepository;
        }
    }
}
