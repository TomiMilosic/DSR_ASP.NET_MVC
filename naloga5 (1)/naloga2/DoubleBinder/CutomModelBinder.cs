using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace naloga2.DoubleBinder
{
    public class CutomModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException(nameof(bindingContext));

            var valuesVlaznost = bindingContext.ValueProvider.GetValue("Vlaznost");
            var valuesTemparatura = bindingContext.ValueProvider.GetValue("Temparatura");




            return Task.CompletedTask;
        }
    }
}
