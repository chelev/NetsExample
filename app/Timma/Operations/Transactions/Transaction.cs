﻿using BBS.BAXI;
using Newtonsoft.Json;
using System;

namespace Timma.Operations.Transactions
{
    abstract class Transaction : Operation<TransferAmountArgs>
    {
        public override TransferAmountArgs Args { get; protected set; }
        public override string PrintText { get; protected set; }

        public Transaction (string printText = "", string payload = "{}") : this(0, printText, payload) { }

        public Transaction(int amount, string printText = "", string payload = "{}")
        {
            TransferAmountArgs args = getTransactionArgs(payload);
            PrintText = printText;
            args.Amount1 = args.Amount1 == 0 ? amount : args.Amount1;
            setup(args);
        }

        private TransferAmountArgs getTransactionArgs(string payload)
        {
            payload = string.IsNullOrWhiteSpace(payload) ? "{}" : payload;
            return JsonConvert.DeserializeObject<TransferAmountArgs>(payload);
        }

        private void setup (TransferAmountArgs args)
        {
            args.OperID = args.OperID ?? DEFAULT_OPERATOR_ID;

            args.Type1 = Type1;
            args.Type2 = Type2;
            args.Type3 = Type3;

            Args = args;
        }

        protected abstract int Type1 { get; }

        protected virtual int Type2
        {
            get
            {
                return (int)Type.NotInUse;
            }
        }

        protected virtual int Type3
        {
            get
            {
                return (int)Type.NotInUse;
            }
        }

    }
}