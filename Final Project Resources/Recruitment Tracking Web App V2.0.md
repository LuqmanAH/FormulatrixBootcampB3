# 🆙Recruitment Tracking Web App V2.0

**Muhammad Luqman Al Helmy, Christian Sidebang, Irfan Maulana**

github repository: [Repo Link](https://github.com/LuqmanAH/RecruitmentTracingBeta-v2.0.git)

Recruitment tracking is a website that functions as a platform for candidates to apply for jobs, and administrators to manage job openings, recruitment progress, and other processes related to the recruitment process.

## ❗Problem Description

The legacy codebase of Recruitment Tracking Web App has grown by complexity for the last 3 months. However, due to its lack of documentation and bug accumulation, it poses challenges for the current and future development team handling the codebase. The goal of this Final Project sprint is to refactor possible part of the code, resolve existing bugs, and enhance the overall maintainability by documentation 

Problems: 

1. No proper documentation for google sign in and email notifications to mailtrap
2. Search result page redirects to another viewer, this is redundant as we only need to filter out job view items by the search string
3. The location dropdown at the index introduced by batch 1 removed without any explanation
4. Delete job button in admin area routed to the wrong method

## 🧰 Requirements for Development

1. .NET Framework V7.05
2. ASP NET MVC
3. Sqlite 3

## 🛠️ Development Plan

1. User testing the existing web app to find bugs and unhandled exceptions
2. Document bug and exception findings
3. Resolve bugs and exceptions that is possible
4. Refactor the code and existing features
5. Add feature and revamp visuals from previous sprint notes
6. Unit test the controller functions
7. Complete documentations

## 💹 Diagrams

- Class Diagram: [temporary Class diagram (not reviewed)](https://docs.google.com/document/d/1SWoWXPN_ZKA0H7u5-50r8lTSvk4WbBm-y9lCUg4CMHQ/edit)
- ERD
- etc

## 🆕 Implemented Development

Progress by 27 Aug 2023:
1. Reimplemented the Filter by location dropdown
2. Added department table + relation with jobs, minimum education column, and employment type column
3. Added Read functionality for the department table via foreign key
4. Updated job editor and creator to allow data binding with new columns and department table
5. Added Filter by department dropdown
6. Streamlined search feature by removing redundant viewer and using HTTP Post method
7. Visual front-end updates

TODOs:
1. Verify and document email sender for candidate process notifications and sign in with google 
2. Create CUD for the department table
3. Preparing for controller unit testing
4. Preparing to revamp documentations
5. Understanding the system again - find bugs that might still be lurking in the codebase

---

- Fixes Made
- Additional Features
- Documentation

---
misc: [Atraksi External Login Irfan](https://docs.google.com/document/d/1O_cJ7Jlt2DglXoV95CP2br87FQUwX6WlrM-fefjaQlw/edit#heading=h.clqjupxiz03w)

## 💾 Database Migration History

## 📖 Lessons Learned

## 🗺️  Future Developments