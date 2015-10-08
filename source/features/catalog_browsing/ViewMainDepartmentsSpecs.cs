using code.web;
using developwithpassion.specifications.assertions;
using developwithpassion.specifications.observations;
using developwithpassion.specifications.should;
using Machine.Fakes.Adapters.Rhinomocks;
using Machine.Specifications;

namespace code.features.catalog_browsing
{  
  [Subject(typeof(ViewMainDepartments))]  
  public class ViewMainDepartmentsSpecs
  {

    public abstract class concern : Spec.isolate_with<RhinoFakeEngine>.observe<IRunAUserFeature,ViewMainDepartments>
    {
        
    }

   
    public class when_run : concern
    {
      Establish c = () =>
      {
        request = fake.an<IProvideDetailsToHandlers>();
        departments = depends.on<IGetDepartments>();
      };

      Because b = () =>
        sut.process(request);

      It gets_the_main_departments = () =>
        departments.should().have_received(x => x.main_departments());

      static IGetDepartments departments;
      static IProvideDetailsToHandlers request;
    }
  }
}
