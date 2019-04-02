﻿namespace Raven.Documentation.Samples.ClientApi
{
    using System;
    using Client.Documents;

    public class CreatingDocumentStore
    {
        public CreatingDocumentStore()
        {
            #region document_store_creation

            using (IDocumentStore store = new DocumentStore()
            {
                Urls = new[] { "http://localhost:8080" }
            }.Initialize())
            {

            }

            #endregion
        }

        #region document_store_holder
        //how to generate a singleton document store
        public class DocumentStoreHolder
        {
            private static Lazy<IDocumentStore> store = new Lazy<IDocumentStore>(CreateStore);

            public static IDocumentStore Store => store.Value;

            private static IDocumentStore CreateStore()
            {
                IDocumentStore store = new DocumentStore()
                {
                    Urls = new[] { "http://your_RavenDB_cluster_node_A",
                        "http://your_RavenDB_cluster_node_B", "..." },
                    Database = "your_database_name"
                }.Initialize();

                return store;
            }
        }
        #endregion
    }
}
