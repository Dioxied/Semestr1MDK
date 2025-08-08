using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RestangleArea_5and5_25returned()
        {
            int a = 5;
            int b = 5;
            int expected = 25;

            Geometry g = new Geometry();
            int actual = g.S(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RestangleArea_1and7_8returned()
        {
            int a = 1;
            int b = 7;
            int expected = 8;

            Geometry g = new Geometry();
            int actual = g.S(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RestangleArea_12and7_19returned()
        {
            int a = 12;
            int b = 7;
            int expected = 19;

            Geometry g = new Geometry();
            int actual = g.S(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RestangleArea_4and7_28returned()
        {
            int a = 4;
            int b = 7;
            int expected = 28;

            Geometry g = new Geometry();
            int actual = g.S(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RestangleArea_8and8_54returned()
        {
            int a = 8;
            int b = 8;
            int expected = 54;

            Geometry g = new Geometry();
            int actual = g.S(a, b);

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class RP
    {
        [TestMethod]
        public void rp_3and3_9returned()
        {
            int a = 3;
            int b = 3;
            int expected = 9;

            rectangle_perimeter rp = new rectangle_perimeter();
            int actual = rp.P(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void rp_2and3_5returned()
        {
            int a = 2;
            int b = 3;
            int expected = 5;

            rectangle_perimeter rp = new rectangle_perimeter();
            int actual = rp.P(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void rp_6and4_20returned()
        {
            int a = 6;
            int b = 4;
            int expected = 20;

            rectangle_perimeter rp = new rectangle_perimeter();
            int actual = rp.P(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void rp_5and8_40returned()
        {
            int a = 5;
            int b = 8;
            int expected = 40;

            rectangle_perimeter rp = new rectangle_perimeter();
            int actual = rp.P(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void rp_20and12_43returned()
        {
            int a = 20;
            int b = 12;
            int expected = 43;

            rectangle_perimeter rp = new rectangle_perimeter();
            int actual = rp.P(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void rp_10and10_40returned()
        {
            int a = 10;
            int b = 10;
            int expected = 40;

            rectangle_perimeter rp = new rectangle_perimeter();
            int actual = rp.P(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void rp_6and9_30returned()
        {
            int a = 6;
            int b = 9;
            int expected = 30;

            rectangle_perimeter rp = new rectangle_perimeter();
            int actual = rp.P(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void rp_15and15_60returned()
        {
            int a = 15;
            int b = 15;
            int expected = 60;

            rectangle_perimeter rp = new rectangle_perimeter();
            int actual = rp.P(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void rp_45and45_100returned()
        {
            int a = 45;
            int b = 45;
            int expected = 100;

            rectangle_perimeter rp = new rectangle_perimeter();
            int actual = rp.P(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void rp_32and20_104returned()
        {
            int a = 32;
            int b = 20;
            int expected = 104;

            rectangle_perimeter rp = new rectangle_perimeter();
            int actual = rp.P(a, b);
            Assert.AreEqual(expected, actual);
        }

    }

    [TestClass]
    public class CV
    {
        [TestMethod]
        public void cv_2and3_5returned()
        {
            int R = 2;
            int h = 3;
            int expected = 5;

            cylinder_volume cv = new cylinder_volume();
            int actual = cv.V(R, h);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void cv_5and3_14returned()
        {
            int R = 5;
            int h = 3;
            int expected = 14;

            cylinder_volume cv = new cylinder_volume();
            int actual = cv.V(R, h);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void cv_4and7_73returned()
        {
            int R = 4;
            int h = 7;
            int expected = 73;

            cylinder_volume cv = new cylinder_volume();
            int actual = cv.V(R, h);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void cv_12and5_60returned()
        {
            int R = 12;
            int h = 5;
            int expected = 60;

            cylinder_volume cv = new cylinder_volume();
            int actual = cv.V(R, h);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void cv_83and4_282returned()
        {
            int R = 4;
            int h = 83;
            int expected = 282;

            cylinder_volume cv = new cylinder_volume();
            int actual = cv.V(R, h);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void cv_54and4_2714returned()
        {
            int R = 4;
            int h = 54;
            int expected = 2714;

            cylinder_volume cv = new cylinder_volume();
            int actual = cv.V(R, h);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void cv_36and12_16286returned()
        {
            int R = 12;
            int h = 36;
            int expected = 16286;

            cylinder_volume cv = new cylinder_volume();
            int actual = cv.V(R, h);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void cv_14and3_396returned()
        {
            int R = 3;
            int h = 14;
            int expected = 395;

            cylinder_volume cv = new cylinder_volume();
            int actual = cv.V(R, h);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void cv_23and3_650returned()
        {
            int R = 3;
            int h = 23;
            int expected = 650;

            cylinder_volume cv = new cylinder_volume();
            int actual = cv.V(R, h);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void cv_4and4_201returned()
        {
            int R = 4;
            int h = 4;
            int expected = 201;

            cylinder_volume cv = new cylinder_volume();
            int actual = cv.V(R, h);
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class VSR
    {
        [TestMethod]
        public void vsrV_2and2and3_v10()
        {
            int a = 2;
            int b = 2;
            int c = 3;
            int expected_V = 10;

            VSr vSr = new VSr();
            int actual_V = vSr.V(a, b, c);

            Assert.AreEqual(expected_V, actual_V);
        }
        [TestMethod]
        public void vsrS_2and2and3_s10()
        {
            int a = 2;
            int b = 2;
            int c = 3;
            int expected_S = 10;

            VSr vSr = new VSr();
            int actual_S = vSr.S(a, b, c);

            Assert.AreEqual(expected_S, actual_S);
        }

        [TestMethod]
        public void vsrV_14and3and3_v15()
        {
            int a = 14;
            int b = 3;
            int c = 3;
            int expected_V = 15;

            VSr vSr = new VSr();
            int actual_V = vSr.V(a, b, c);

            Assert.AreEqual(expected_V, actual_V);
        }
        [TestMethod]
        public void vsrS_14and3and3_s15()
        {
            int a = 14;
            int b = 3;
            int c = 3;
            int expected_S = 15;

            VSr vSr = new VSr();
            int actual_S = vSr.S(a, b, c);

            Assert.AreEqual(expected_S, actual_S);
        }

        [TestMethod]
        public void vsrV_21and21and31_v999()
        {
            int a = 21;
            int b = 21;
            int c = 31;
            int expected_V = 999;

            VSr vSr = new VSr();
            int actual_V = vSr.V(a, b, c);

            Assert.AreEqual(expected_V, actual_V);
        }
        [TestMethod]
        public void vsrS_21and21and31_s2342()
        {
            int a = 21;
            int b = 21;
            int c = 31;
            int expected_S = 2342;

            VSr vSr = new VSr();
            int actual_S = vSr.S(a, b, c);

            Assert.AreEqual(expected_S, actual_S);
        }

        [TestMethod]
        public void vsrV_5and5and3_v45()
        {
            int a = 5;
            int b = 5;
            int c = 3;
            int expected_V = 45;

            VSr vSr = new VSr();
            int actual_V = vSr.V(a, b, c);

            Assert.AreEqual(expected_V, actual_V);
        }
        [TestMethod]
        public void vsrS_5and5and3_s20()
        {
            int a = 5;
            int b = 5;
            int c = 3;
            int expected_S = 20;

            VSr vSr = new VSr();
            int actual_S = vSr.S(a, b, c);

            Assert.AreEqual(expected_S, actual_S);
        }

        [TestMethod]
        public void vsrV_43and21and31_v29674()
        {
            int a = 43;
            int b = 21;
            int c = 31;
            int expected_V = 29674;

            VSr vSr = new VSr();
            int actual_V = vSr.V(a, b, c);

            Assert.AreEqual(expected_V, actual_V);
        }
        [TestMethod]
        public void vsrS_43and21and31_s98799()
        {
            int a = 43;
            int b = 21;
            int c = 31;
            int expected_S = 98799;

            VSr vSr = new VSr();
            int actual_S = vSr.S(a, b, c);

            Assert.AreEqual(expected_S, actual_S);
        }

        [TestMethod]
        public void vsrV_3and3and3_v27()
        {
            int a = 3;
            int b = 3;
            int c = 3;
            int expected_V = 27;

            VSr vSr = new VSr();
            int actual_V = vSr.V(a, b, c);

            Assert.AreEqual(expected_V, actual_V);
        }
        [TestMethod]
        public void vsrS_3and3and3_s54()
        {
            int a = 3;
            int b = 3;
            int c = 3;
            int expected_S = 54;

            VSr vSr = new VSr();
            int actual_S = vSr.S(a, b, c);

            Assert.AreEqual(expected_S, actual_S);
        }

        [TestMethod]
        public void vsrV_14and2and6_v168()
        {
            int a = 14;
            int b = 2;
            int c = 6;
            int expected_V = 168;

            VSr vSr = new VSr();
            int actual_V = vSr.V(a, b, c);

            Assert.AreEqual(expected_V, actual_V);
        }
        [TestMethod]
        public void vsrS_14and2and6_s248()
        {
            int a = 14;
            int b = 2;
            int c = 6;
            int expected_S = 248;

            VSr vSr = new VSr();
            int actual_S = vSr.S(a, b, c);

            Assert.AreEqual(expected_S, actual_S);
        }

        [TestMethod]
        public void vsrV_32and5and2_v320()
        {
            int a = 32;
            int b = 5;
            int c = 2;
            int expected_V = 320;

            VSr vSr = new VSr();
            int actual_V = vSr.V(a, b, c);

            Assert.AreEqual(expected_V, actual_V);
        }
        [TestMethod]
        public void vsrS_32and5and2_s468()
        {
            int a = 32;
            int b = 5;
            int c = 2;
            int expected_S = 468;

            VSr vSr = new VSr();
            int actual_S = vSr.S(a, b, c);

            Assert.AreEqual(expected_S, actual_S);
        }

        [TestMethod]
        public void vsrV_15and15and15_v3375()
        {
            int a = 15;
            int b = 15;
            int c = 15;
            int expected_V = 3375;

            VSr vSr = new VSr();
            int actual_V = vSr.V(a, b, c);

            Assert.AreEqual(expected_V, actual_V);
        }
        [TestMethod]
        public void vsrS_15and15and15_s1350()
        {
            int a = 15;
            int b = 15;
            int c = 15;
            int expected_S = 1350;

            VSr vSr = new VSr();
            int actual_S = vSr.S(a, b, c);

            Assert.AreEqual(expected_S, actual_S);
        }

        [TestMethod]
        public void vsrV_61and3and34_v6222()
        {
            int a = 61;
            int b = 3;
            int c = 34;
            int expected_V = 6222;

            VSr vSr = new VSr();
            int actual_V = vSr.V(a, b, c);

            Assert.AreEqual(expected_V, actual_V);
        }
        [TestMethod]
        public void vsrS_61and3and34_s4718()
        {
            int a = 61;
            int b = 3;
            int c = 34;
            int expected_S = 4718;

            VSr vSr = new VSr();
            int actual_S = vSr.S(a, b, c);

            Assert.AreEqual(expected_S, actual_S);
        }
    }
}
