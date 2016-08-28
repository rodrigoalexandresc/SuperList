using Raven.Client;
using Raven.Client.Embedded;
using System;

namespace SuperList.Infra.Repository.RavenDB
{
    public class DataDocumentStore
    {
        private static IDocumentStore instance;

        public static IDocumentStore Instance
        {
            get
            {
                if (instance == null)
                    throw new InvalidOperationException("DocumentStore não inicializado");

                return instance;
            }
        }

        public static IDocumentStore Initialize()
        {
            instance = new EmbeddableDocumentStore { ConnectionStringName = "RavenDB" };
            instance.Conventions.IdentityPartsSeparator = "-";
            instance.Initialize();
            return instance;
        }

    }
}
