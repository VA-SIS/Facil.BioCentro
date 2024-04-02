using System;
using System.Collections.Generic;
using System.Text;
using Facil.BioCentro.Localization;
using Volo.Abp.Application.Services;

namespace Facil.BioCentro;

/* Inherit your application services from this class.
 */
public abstract class BioCentroAppService : ApplicationService
{
    protected BioCentroAppService()
    {
        LocalizationResource = typeof(BioCentroResource);
    }
}
