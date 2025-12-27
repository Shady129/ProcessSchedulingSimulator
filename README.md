# ⚙️ Process Scheduling Simulator (C#)

A simple **console-based simulator** for CPU process scheduling using the  
**Shortest Remaining Time First (SRTF)** algorithm.

---

## 🧠 Overview

This project simulates how an operating system schedules processes on the CPU  
**time unit by time unit**, based on the remaining execution time of each process.

It demonstrates:
- Preemptive scheduling
- Process arrival over time
- Real-time decision making by the scheduler

---

## ✨ Features

✅ Time-based simulation  
✅ Preemptive scheduling (SRTF)  
✅ Supports Arrival Time  
✅ Clear execution timeline output  
✅ Object-Oriented Design  

---

## 🧮 Scheduling Algorithm

🔹 **SRTF – Shortest Remaining Time First**

- At each time unit, the scheduler selects the process with the **smallest remaining execution time**
- If a shorter process arrives, it **preempts** the current one

---

## 🧱 Project Structure

📁 **Process.cs**  
- Represents a single process  
- Properties:
  - Name
  - ArrivalTime
  - BurstTime
  - RemainingTime  

📁 **Scheduler.cs**  
- Core scheduling logic  
- Manages:
  - Current Time
  - Ready Queue
  - Completed Processes  
- Implements:
  - SRTF selection
  - Time unit execution  

📁 **Program.cs**  
- Entry point  
- Adds processes  
- Runs the simulation loop  

---

## ▶️ Example Output

```text
0 -> P1
1 -> P2
2 -> P3
3 -> P2
4 -> P2
5 -> P1
6 -> P1
7 -> P1
8 -> P1
