using System;
using System.Threading.Tasks;
using NGraphQL.CodeFirst;
using NGraphQL.Model;

namespace NGraphQL.Server {

  /// <summary>Hook called before a field resolver is invoked; register it in <see cref="GraphQLServer.FieldResolvingHooks"/>. </summary>
  /// <remarks>The hook is called once per field per execution level, not once per parent object: for a list of N parents
  /// it is called once. It is called for fields with resolver methods and for fields read directly from entity properties.
  /// To reject the field, add an error to the field context and throw <see cref="AbortRequestException"/>
  /// (for ex. with <c>fieldContext.AbortIf(...)</c>); any other exception is reported as a resolver error. </remarks>
  public interface IFieldResolvingHook {
    Task OnFieldResolvingAsync(IFieldContext fieldContext, FieldResolverInfo resolver);
  }
}
