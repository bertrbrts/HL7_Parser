using Google.Cloud.Functions.Testing;
using HL7Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

public class TestingBase : FunctionTestBase<ProcessHL7Message>
{
    public void HandleAssertFail(Exception ex)
    {
        Assert.Fail(ex.Message);
    }
}