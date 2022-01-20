using care.ai.cloud.functions;
using Google.Cloud.Functions.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

public class TestingBase : FunctionTestBase<processHL7Message>
{
    public void HandleAssertFail(Exception ex)
    {
        Assert.Fail(ex.Message);
    }

}