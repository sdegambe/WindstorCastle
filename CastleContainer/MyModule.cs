using Castle.Core.Configuration;
using Castle.Core.Resource;
using Castle.MicroKernel;
using Castle.MicroKernel.SubSystems.Configuration;

namespace CastleContainer
{
    internal class MyModule : IConfigurationStore
    {
        public void Init(IKernelInternal kernel)
        {
            throw new System.NotImplementedException();
        }

        public void Terminate()
        {
            throw new System.NotImplementedException();
        }

        public void AddChildContainerConfiguration(string name, IConfiguration config)
        {
            throw new System.NotImplementedException();
        }

        public void AddComponentConfiguration(string key, IConfiguration config)
        {
            throw new System.NotImplementedException();
        }

        public void AddFacilityConfiguration(string key, IConfiguration config)
        {
            throw new System.NotImplementedException();
        }

        public void AddInstallerConfiguration(IConfiguration config)
        {
            throw new System.NotImplementedException();
        }

        public IConfiguration GetChildContainerConfiguration(string key)
        {
            throw new System.NotImplementedException();
        }

        public IConfiguration GetComponentConfiguration(string key)
        {
            throw new System.NotImplementedException();
        }

        public IConfiguration[] GetComponents()
        {
            throw new System.NotImplementedException();
        }

        public IConfiguration[] GetConfigurationForChildContainers()
        {
            throw new System.NotImplementedException();
        }

        public IConfiguration[] GetFacilities()
        {
            throw new System.NotImplementedException();
        }

        public IConfiguration GetFacilityConfiguration(string key)
        {
            throw new System.NotImplementedException();
        }

        public IConfiguration[] GetInstallers()
        {
            throw new System.NotImplementedException();
        }

        public IResource GetResource(string resourceUri, IResource resource)
        {
            throw new System.NotImplementedException();
        }
    }
}