﻿using Rolcore.Net.WebMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Rolcore.Net.Tests
{
    
    
    /// <summary>
    ///This is a test class for WebMethodsHtmlResponseObjectTest and is intended
    ///to contain all WebMethodsHtmlResponseObjectTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WebMethodsHtmlResponseObjectTest
    {

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        [TestMethod()]
        public void Constructor()
        {
            StringBuilder b = new StringBuilder();
            b.AppendLine("<BODY bgcolor=#dddddd>");
            b.AppendLine("<TABLE bgcolor=#dddddd border=1>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>BranchInformationList</B></TD>");
            b.AppendLine("<TD>");
            b.AppendLine("<TABLE>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD><TABLE bgcolor=#dddddd border=1>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>Location</B></TD>");
            b.AppendLine("<TD><TABLE bgcolor=#dddddd border=1>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>Id</B></TD>");
            b.AppendLine("<TD>200  </TD>");
            b.AppendLine("");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>Description</B></TD>");
            b.AppendLine("<TD>ORKIN - BUCKHEAD, GA          </TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>PostalAddress</B></TD>");
            b.AppendLine("<TD><TABLE bgcolor=#dddddd border=1>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>AddressLine</B></TD>");
            b.AppendLine("<TD>");
            b.AppendLine("<TABLE>");
            b.AppendLine("<TR>");
            b.AppendLine("");
            b.AppendLine("<TD>1400 MARIETTA BLVD NW STE A   </TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD>                              </TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>City</B></TD>");
            b.AppendLine("<TD>ATLANTA                  </TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("");
            b.AppendLine("<TD valign=top><B>StateOrProvince</B></TD>");
            b.AppendLine("<TD>GA</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>PostalCode</B></TD>");
            b.AppendLine("<TD>30318</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>Phone</B></TD>");
            b.AppendLine("<TD>4043507110          </TD>");
            b.AppendLine("</TR>");
            b.AppendLine("");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>Fax</B></TD>");
            b.AppendLine("<TD>4043518490          </TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>BranchHirarchy</B></TD>");
            b.AppendLine("<TD><TABLE bgcolor=#dddddd border=1>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>Levels</B></TD>");
            b.AppendLine("<TD><TABLE bgcolor=#dddddd border=1>");
            b.AppendLine("");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>BranchNum</B></TD>");
            b.AppendLine("<TD>200  </TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>RegionNum</B></TD>");
            b.AppendLine("<TD>169  </TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>DivisionNum</B></TD>");
            b.AppendLine("<TD>81   </TD>");
            b.AppendLine("");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>CompanyNum</B></TD>");
            b.AppendLine("<TD>01   </TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>HasAdminCenter</B></TD>");
            b.AppendLine("<TD>N</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>AdminCenterNum</B></TD>");
            b.AppendLine("<TD>0</TD>");
            b.AppendLine("");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("");
            b.AppendLine("<TD valign=top><B>BranchResult</B></TD>");
            b.AppendLine("<TD><TABLE bgcolor=#dddddd border=1>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>Output</B></TD>");
            b.AppendLine("<TD><TABLE bgcolor=#dddddd border=1>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>returnCode</B></TD>");
            b.AppendLine("<TD>Y</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>returnMsg</B></TD>");
            b.AppendLine("<TD>BRANCH FOUND</TD>");
            b.AppendLine("");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>branchCount</B></TD>");
            b.AppendLine("<TD>1</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>branchNum</B></TD>");
            b.AppendLine("<TD>");
            b.AppendLine("<TABLE>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD>200</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</BODY>");

            WebMethodsHtmlResponseObject o = new WebMethodsHtmlResponseObject(b.ToString());
            Assert.AreEqual(o["BranchInformationList"]["Location"]["Id"].AsString, "200");
            Assert.AreEqual(o["BranchInformationList.Location.PostalAddress.City"].AsString, "ATLANTA");
        }

        [TestMethod(), ExpectedException(typeof(WebMethodsHtmlResponseException))]
        public void TestExceptionResponse()
        {
            StringBuilder b = new StringBuilder();
            b.AppendLine("<BODY bgcolor=#dddddd>");
            b.AppendLine("<TABLE bgcolor=#dddddd border=1>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$errorDump</B></TD>");
            b.AppendLine("<TD>com.wm.app.b2b.server.UnknownServiceException: Rol.System.RCCC.out.Zipcode.wrapper:getBranchByZipS");
            b.AppendLine("	at com.wm.app.b2b.server.HTTPInvokeHandler._process(HTTPInvokeHandler.java:61)");
            b.AppendLine("	at com.wm.app.b2b.server.InvokeHandler.process(InvokeHandler.java:119)");
            b.AppendLine("	at com.wm.app.b2b.server.Dispatch.run(Dispatch.java:312)");
            b.AppendLine("	at com.wm.util.pool.PooledThread.run(PooledThread.java:105)");
            b.AppendLine("	at java.lang.Thread.run(Thread.java:797)");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$errorInfo</B></TD>");
            b.AppendLine("<TD><TABLE bgcolor=#dddddd border=1>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$errorDump</B></TD>");
            b.AppendLine("<TD>com.wm.app.b2b.server.UnknownServiceException: Rol.System.RCCC.out.Zipcode.wrapper:getBranchByZipS");
            b.AppendLine("	at com.wm.app.b2b.server.HTTPInvokeHandler._process(HTTPInvokeHandler.java:61)");
            b.AppendLine("	at com.wm.app.b2b.server.InvokeHandler.process(InvokeHandler.java:119)");
            b.AppendLine("	at com.wm.app.b2b.server.Dispatch.run(Dispatch.java:312)");
            b.AppendLine("	at com.wm.util.pool.PooledThread.run(PooledThread.java:105)");
            b.AppendLine("	at java.lang.Thread.run(Thread.java:797)");
            b.AppendLine("</TD>");
            b.AppendLine("");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$error</B></TD>");
            b.AppendLine("<TD>Rol.System.RCCC.out.Zipcode.wrapper:getBranchByZipS</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$localizedError</B></TD>");
            b.AppendLine("<TD>Rol.System.RCCC.out.Zipcode.wrapper:getBranchByZipS</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$errorType</B></TD>");
            b.AppendLine("<TD>com.wm.app.b2b.server.UnknownServiceException</TD>");
            b.AppendLine("");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$user</B></TD>");
            b.AppendLine("<TD>Default</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$time</B></TD>");
            b.AppendLine("<TD>2008-04-25 07:37:08 EDT</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$details</B></TD>");
            b.AppendLine("<TD></TD>");
            b.AppendLine("");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$errorMsgId</B></TD>");
            b.AppendLine("<TD></TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$error</B></TD>");
            b.AppendLine("<TD>Rol.System.RCCC.out.Zipcode.wrapper:getBranchByZipS</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("<TR>");
            b.AppendLine("<TD valign=top><B>$errorType</B></TD>");
            b.AppendLine("");
            b.AppendLine("<TD>com.wm.app.b2b.server.UnknownServiceException</TD>");
            b.AppendLine("</TR>");
            b.AppendLine("</TABLE>");
            b.AppendLine("</BODY>");

            WebMethodsHtmlResponseObject o = new WebMethodsHtmlResponseObject(b.ToString());
        }
    }
}
