﻿namespace Snippets5.UpgradeGuides._5to6
{
    using NServiceBus;

    class Transactions
    {
        public void SetDistributedTransactions()
        {
            EndpointConfiguration endpointConfiguration = new EndpointConfiguration();

            #region 5to6-enable-native-transaction

            endpointConfiguration
                .UseTransport<SqlServerTransport>()
                .Transactions(TransportTransactionMode.SendsAtomicWithReceive);

            #endregion
        }
    }
}