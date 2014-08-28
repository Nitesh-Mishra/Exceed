-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jun 09, 2013 at 08:46 PM
-- Server version: 5.5.24-log
-- PHP Version: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `exceed`
--

-- --------------------------------------------------------

--
-- Table structure for table `add_subject`
--

CREATE TABLE IF NOT EXISTS `add_subject` (
  `Class_Name` varchar(10) NOT NULL,
  `Sub_Name` varchar(20) NOT NULL,
  `Sub_Id` varchar(15) NOT NULL,
  `Fees` int(11) NOT NULL,
  PRIMARY KEY (`Class_Name`,`Sub_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `add_subject`
--

INSERT INTO `add_subject` (`Class_Name`, `Sub_Name`, `Sub_Id`, `Fees`) VALUES
('09', 'Maths', 'M9', 300),
('09', 'Science', 'S9', 300),
('10', 'Maths', 'M10', 300),
('10', 'Science', 'S10', 300),
('11', 'Chemistry', 'C11', 300),
('11', 'Maths', 'M11', 300),
('11', 'Physics', 'P11', 300),
('12', 'Chemistry', 'C12', 300),
('12', 'Maths', 'M12', 300),
('12', 'Physics', 'P12', 300);

-- --------------------------------------------------------

--
-- Table structure for table `add_test`
--

CREATE TABLE IF NOT EXISTS `add_test` (
  `DOT` date NOT NULL,
  `Class` varchar(10) NOT NULL,
  `Sub_Id` varchar(10) NOT NULL,
  `Max_Marks` int(11) NOT NULL,
  `Test_Id` varchar(20) NOT NULL,
  PRIMARY KEY (`Test_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `add_test`
--

INSERT INTO `add_test` (`DOT`, `Class`, `Sub_Id`, `Max_Marks`, `Test_Id`) VALUES
('2013-03-15', '09', 'M9', 100, 'T01'),
('2013-05-15', '09', 'S9', 100, 'T02'),
('2013-05-17', '09', 'M9', 100, 'T03'),
('2013-05-04', '11', 'M11', 100, 'T04'),
('2013-05-04', '11', 'P11', 100, 'T05'),
('2013-06-09', '09', 'M9', 50, 'T10');

-- --------------------------------------------------------

--
-- Table structure for table `assignment`
--

CREATE TABLE IF NOT EXISTS `assignment` (
  `Year` varchar(11) NOT NULL,
  `Class` varchar(20) NOT NULL,
  `Subject_Id` varchar(20) NOT NULL,
  `Submission_Date` date NOT NULL,
  `Assignment` varchar(50) NOT NULL,
  `Student_Id` varchar(30) NOT NULL,
  `Status` varchar(12) NOT NULL,
  PRIMARY KEY (`Year`,`Submission_Date`,`Assignment`,`Student_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assignment`
--

INSERT INTO `assignment` (`Year`, `Class`, `Subject_Id`, `Submission_Date`, `Assignment`, `Student_Id`, `Status`) VALUES
('2013', '09', 'S9', '0000-00-00', 'mt', 'SE-13-09-01', 'Yes'),
('2013', '09', 'M9', '0000-00-00', 'sc', 'SE-13-09-01', 'Yes');

-- --------------------------------------------------------

--
-- Table structure for table `assign_subject`
--

CREATE TABLE IF NOT EXISTS `assign_subject` (
  `Class_Detail` varchar(5) NOT NULL,
  `Student_Id` varchar(20) NOT NULL,
  `Sub_Id` varchar(20) NOT NULL,
  PRIMARY KEY (`Student_Id`,`Sub_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assign_subject`
--

INSERT INTO `assign_subject` (`Class_Detail`, `Student_Id`, `Sub_Id`) VALUES
('09', 'SE-13-09-01', 'M9'),
('09', 'SE-13-09-01', 'S9'),
('10 ', 'SE-13-09-02', 'M10'),
('10 ', 'SE-13-09-02', 'S10'),
('11', 'SE-13-09-03', 'C11'),
('11', 'SE-13-09-03', 'M11'),
('11', 'SE-13-09-03', 'P11'),
('12', 'SE-13-09-04', 'C12'),
('12', 'SE-13-09-04', 'M12'),
('12', 'SE-13-09-04', 'P12');

-- --------------------------------------------------------

--
-- Table structure for table `faculty_performance`
--

CREATE TABLE IF NOT EXISTS `faculty_performance` (
  `Year` varchar(11) NOT NULL,
  `Class` varchar(11) NOT NULL,
  `Subject_Id` varchar(11) NOT NULL,
  `Faculty_Name` varchar(40) NOT NULL,
  `Topic` varchar(40) NOT NULL,
  `Date` date NOT NULL,
  `Test` varchar(11) NOT NULL,
  `Result` varchar(11) NOT NULL,
  `Remark` varchar(40) NOT NULL,
  PRIMARY KEY (`Year`,`Class`,`Subject_Id`,`Faculty_Name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `faculty_performance`
--

INSERT INTO `faculty_performance` (`Year`, `Class`, `Subject_Id`, `Faculty_Name`, `Topic`, `Date`, `Test`, `Result`, `Remark`) VALUES
('2013', '09', 'M9', 'nitesh', 'Linear Equation', '2013-06-04', 'No', 'Yes', 'Good');

-- --------------------------------------------------------

--
-- Table structure for table `fees_status`
--

CREATE TABLE IF NOT EXISTS `fees_status` (
  `Year` varchar(11) NOT NULL,
  `Class` varchar(20) NOT NULL,
  `Student_Id` varchar(20) NOT NULL,
  `Total_Amount` int(11) NOT NULL,
  `Amount_Paid` int(11) NOT NULL,
  `Due_Amount` int(11) NOT NULL,
  `Date_Of_Payment` date NOT NULL,
  `Mode_Of_Payment` varchar(10) NOT NULL,
  `Check_DD_No` varchar(30) NOT NULL,
  PRIMARY KEY (`Year`,`Student_Id`,`Date_Of_Payment`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fees_status`
--

INSERT INTO `fees_status` (`Year`, `Class`, `Student_Id`, `Total_Amount`, `Amount_Paid`, `Due_Amount`, `Date_Of_Payment`, `Mode_Of_Payment`, `Check_DD_No`) VALUES
('2012-13', '09', 'a', 500, 300, 200, '0000-00-00', 'Cash', 'Not Available'),
('2012-13', '09', 'a', 7000, 2000, 500, '2013-05-15', 'Cash', 'Not Available'),
('2012-13', '10', 'b', 80, 65, 9, '2013-05-15', 'Cash', 'Not Available'),
('2013', '09', 'SE-13-09-01', 2000, 800, 800, '2013-06-02', 'Cash', 'Not Available'),
('2013', '09', 'SE-13-09-01', 2000, 400, 400, '2013-06-03', 'Cash', 'Not Available'),
('2013', '09', 'SE-13-09-01', 2000, 400, 0, '2013-06-04', 'Cash', 'Not Available'),
('2013', '10', 'SE-13-09-02', 7000, 3000, 3000, '0000-00-00', 'Cash', 'Not Available'),
('2013', '11', 'SE-13-09-03', 10000, 1500, 8000, '2013-06-03', 'Cash', 'Not Available'),
('2013', '11', 'SE-13-09-03', 10000, 1000, 7000, '2013-06-05', 'Cash', 'Not Available'),
('2013', '11', 'SE-13-09-03', 10000, 7000, 0, '2013-06-07', 'Cash', ''),
('2013', '12', 'SE-13-09-04', 12000, 3000, 9000, '2013-06-02', 'Cash', 'Not Available'),
('2013', '12', 'SE-13-09-04', 12000, 2000, 7000, '2013-06-03', 'Cash', 'Not Available'),
('2013', '12', 'SE-13-12-04', 4000, 2000, 1600, '0000-00-00', 'Cash', 'Not Available');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `User_Id` varchar(30) NOT NULL,
  `Password` varchar(40) NOT NULL,
  `user_type` varchar(10) NOT NULL,
  `S_Question` varchar(50) NOT NULL,
  `S_Question_Answer` varchar(25) NOT NULL,
  PRIMARY KEY (`User_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`User_Id`, `Password`, `user_type`, `S_Question`, `S_Question_Answer`) VALUES
('a', 'a', 'admin', 'What was your first salary ?', '90'),
('ankit', 'kul', 'operator', 'What was your first salary ?', '9000'),
('hello', 'abe', '', 'What is the name of Your Mother in Law ?', 'jija'),
('m', 'm', '', 'What was your first salary ?', '9'),
('Master', 'aa', '', 'What was your first salary ?', '9000'),
('n', 'n', 'admin', 'What is the name of Your Mother in Law ?', 'rita'),
('nitesh', 'nitesh', '', 'What was your first salary ?', '9000'),
('rahulsagore', 'sagore', '', 'What was your first salary ?', '9000'),
('user', 'useruser', '', 'What was your first salary ?', '8000');

-- --------------------------------------------------------

--
-- Table structure for table `marks_status`
--

CREATE TABLE IF NOT EXISTS `marks_status` (
  `Student_Id` varchar(20) NOT NULL,
  `Class` int(11) NOT NULL,
  `Test_Id` varchar(20) NOT NULL,
  `DOT` date NOT NULL,
  `Marks_Obt` varchar(11) NOT NULL,
  PRIMARY KEY (`Student_Id`,`Test_Id`,`DOT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `marks_status`
--

INSERT INTO `marks_status` (`Student_Id`, `Class`, `Test_Id`, `DOT`, `Marks_Obt`) VALUES
('SE-13-09-01', 9, 'T01', '2013-03-15', '15'),
('SE-13-09-01', 9, 'T01', '2013-06-09', '89'),
('SE-13-09-01', 9, 'T02', '2013-03-15', '54'),
('SE-13-09-01', 9, 'T10', '2013-06-09', '40'),
('SE-13-09-02', 9, 'T01', '2013-03-15', 'Absent'),
('SE-13-09-02', 9, 'T02', '2013-04-15', '22'),
('SE-13-09-03', 9, 'T01', '2013-03-15', 'Absent'),
('SE-13-09-04', 9, 'T02', '2013-03-15', '44'),
('SE-13-11-01', 11, 'T04', '2013-05-04', '76'),
('SE-13-11-01', 11, 'T05', '2013-05-04', '90'),
('SE-13-11-02', 11, 'T04', '2013-05-04', '66'),
('SE-13-11-02', 11, 'T05', '2013-05-04', '95');

-- --------------------------------------------------------

--
-- Table structure for table `security_question_table`
--

CREATE TABLE IF NOT EXISTS `security_question_table` (
  `S.No` int(2) NOT NULL AUTO_INCREMENT,
  `S_Question` varchar(50) NOT NULL,
  PRIMARY KEY (`S.No`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `security_question_table`
--

INSERT INTO `security_question_table` (`S.No`, `S_Question`) VALUES
(1, 'What is the name of Your Mother in Law ?'),
(2, 'What was your first salary ?'),
(3, 'What is the name of your Best Friend''s mother ?'),
(4, 'What is your father''s date of birth ?'),
(5, 'What is the name of your favorite teacher ?');

-- --------------------------------------------------------

--
-- Table structure for table `student_info`
--

CREATE TABLE IF NOT EXISTS `student_info` (
  `Student_Id` varchar(20) NOT NULL,
  `Year` varchar(11) NOT NULL,
  `Class` int(11) NOT NULL,
  `DOJ` date NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Fname` varchar(40) NOT NULL,
  `DOB` date NOT NULL,
  `Address` varchar(60) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `School` varchar(40) NOT NULL,
  `Phone` varchar(11) NOT NULL,
  `Student_Email` varchar(40) NOT NULL,
  `Guardian_Email` varchar(40) NOT NULL,
  `SLCP` varchar(10) NOT NULL,
  `PCI` varchar(40) NOT NULL,
  PRIMARY KEY (`Student_Id`,`Year`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_info`
--

INSERT INTO `student_info` (`Student_Id`, `Year`, `Class`, `DOJ`, `Name`, `Fname`, `DOB`, `Address`, `Gender`, `School`, `Phone`, `Student_Email`, `Guardian_Email`, `SLCP`, `PCI`) VALUES
('SE-13-09-01', '2013', 9, '2013-03-12', 'Ajeet Khan', 'Faimuddin Khan', '2013-03-12', 'Mhow gao, shanti nagar', 'Male', 'Milatray Academy', '9039787767', 'akhan.iips@gmail,com', 'akhan.iipsmca@gmail.com', '', ''),
('SE-13-09-02', '2013', 9, '2013-03-12', 'Rahul Sagore', 'Kailash sagore', '2013-03-11', 'RNT hostel, indore', 'Male', 'Everest English school', '8085605956', 'rahul@gmail.com', 'rahul.sagore@gmail.com', '', ''),
('SE-13-09-03', '2013', 9, '2013-03-12', 'Nitesh Mishra', 'Satyanarayan mishra', '2013-03-01', 'Mhow gao, indore', 'Male', 'Milatry academy', '9039754355', 'nitesh@gmail.com', 'nmmishra.iipsmca@gmail.com', '', ''),
('SE-13-09-04', '2013', 12, '2013-03-10', 'Ankit KulKarni', 'Gajanan Kulkarni', '2013-03-06', 'Hatesing Goyal Colony , Dewas', 'Male', 'Ebenezer HS school', '7867509873', 'ankit@gmail.com', 'ankit.kul1890@gmail.com', '', ''),
('SE-13-11-02', '2013', 11, '2013-05-01', 'Arpit Bhawar', 'Lalit Bhawar', '2013-04-01', '14 Rajendra nagar , indore', 'Male', 'Ebenezer', '7566767757', 'arpit@gmail.com', 'arpitfather@gmail.com', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `study_material`
--

CREATE TABLE IF NOT EXISTS `study_material` (
  `Year` varchar(10) NOT NULL,
  `Class` int(11) NOT NULL,
  `Subject_Id` varchar(15) NOT NULL,
  `Topic` varchar(30) NOT NULL,
  `Print_Status` varchar(10) NOT NULL,
  PRIMARY KEY (`Year`,`Subject_Id`,`Topic`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `study_material`
--

INSERT INTO `study_material` (`Year`, `Class`, `Subject_Id`, `Topic`, `Print_Status`) VALUES
('2013', 10, 'M10', 'Trignometry', 'Ready'),
('2013', 9, 'M9', 'Algebra', 'Ready'),
('2013', 9, 'M9', 'Construction', 'Ready'),
('2013', 9, 'M9', 'Probability', 'Ready'),
('2013', 9, 'M9', 'Quadric Equation', 'Ready'),
('2013', 9, 'M9', 'Trignometry', 'Ready'),
('2013', 9, 'S9', 'Linear Equation', 'Ready');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
