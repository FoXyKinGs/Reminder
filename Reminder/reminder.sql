-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 17, 2024 at 05:54 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `reminder`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_reminder`
--

CREATE TABLE `tb_reminder` (
  `id` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Date` datetime NOT NULL,
  `Note` text NOT NULL,
  `created_at` date NOT NULL DEFAULT current_timestamp(),
  `created_by_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_reminder`
--

INSERT INTO `tb_reminder` (`id`, `Title`, `Date`, `Note`, `created_at`, `created_by_id`) VALUES
(1, 'Tugas Pemrograman Desktop', '0000-00-00 00:00:00', 'Membuat video penjelasan aplikasi, sesuai pertemua ke 11 diminggu lalu', '2024-06-12', 0),
(2, 'Tugas Algortima', '0000-00-00 00:00:00', 'Membuat video penjelasan exception short', '2024-06-12', 0),
(3, 'Tugas Pemrograman Web', '2024-06-12 13:38:03', 'Membuat Responsive Website', '2024-06-12', 0),
(4, 'Tugas Desktop', '2024-06-12 21:05:43', 'Tugas membuat video', '2024-06-12', 0),
(5, 'Quiz Algoritma', '2024-06-18 20:52:25', 'Ngebuat Bubble Sorting di C', '2024-06-17', 4),
(6, 'Pemrograman Web', '2024-06-17 22:28:03', 'Buat website responsive', '2024-06-17', 4);

-- --------------------------------------------------------

--
-- Table structure for table `tb_user`
--

CREATE TABLE `tb_user` (
  `id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Nickname` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_user`
--

INSERT INTO `tb_user` (`id`, `Name`, `Email`, `Nickname`, `Password`) VALUES
(1, 'Kresa', 'Kresa@unibi.ac.id', '', '$2a$11$N0udQNap3Erz88XMvRbo9OTGo38Jy9wu7cxSYU.OB8k'),
(2, 'Kresa', 'Kresa778@gmail.com', '', '$2a$11$2OkBBLKghTpPkex2Xukpqe15QMnHJ2JoYILQv5j2Chb'),
(3, 'Kresa', 'Kresaa@gmail.com', '', '$2a$11$SiG5jG4o1S6E2ooFYeMuYeCiaZvwLI6iuxSMWc0QgPr'),
(4, 'Kresa', 'Kresa2024@gmail.com', 'Resa', '$2a$11$FMw.D8Cva4UHesz939I9qO/JYgR/adPUDnyykE3b9euXLR1.Fr9.W'),
(5, 'Dypta', 'Dypta@gmail.com', 'dip', '$2a$11$OVWfTQWY7Mcf4Q3xpKDY/OQd7xAwzxdlJUyZTO0rfCt9fafo5Xxma');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_reminder`
--
ALTER TABLE `tb_reminder`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_user`
--
ALTER TABLE `tb_user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_reminder`
--
ALTER TABLE `tb_reminder`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tb_user`
--
ALTER TABLE `tb_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
