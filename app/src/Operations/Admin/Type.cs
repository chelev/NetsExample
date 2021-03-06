﻿namespace NetsExample.Operations.Admin
{
    public enum Type
    {
        // Implemented operations
        SoftCancel = 0x3132,
        HardCancel = 0x313B,
        Reconciliation = 0x3130,
        SoftwareDownload = 0x313E,
        DatasetDownload = 0x313F,
        // Reports
        XReport = 0x3136,
        ZReport = 0x3137,
        EOT = 0x313A,
        LatestFinancialTransactionReceipt = 0x313C,

        //
        // Extra (not implemented)
        //
        AdminReversal = 0x3134,
        Balance = 0x3135,
        LatestFinancialTransactionResult = 0x313D,
        SendOfflineTransactions = 0x3138,
    }
}
