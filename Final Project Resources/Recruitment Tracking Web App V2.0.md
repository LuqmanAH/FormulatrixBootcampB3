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

### Class Diagram

[Class Diagrams in Mermaid](https://docs.google.com/document/d/1SWoWXPN_ZKA0H7u5-50r8lTSvk4WbBm-y9lCUg4CMHQ/edit)
  
### Entity Relation Diagram
![ERD](img/DB%20ERD%2029-08.png)

## 🆕 Implemented Development

**Progress by 29 Aug 2023**:
1. Reimplemented the Filter by location dropdown
2. Added department table + relation with jobs, minimum education column, and employment type column
3. Added Read functionality for the department table via foreign key
4. Updated job editor and creator to allow data binding with new columns and department table
   1. Data binding with Department table can access directly the department table 
   2. Data binding with minimum education, location, and employment type currently hardocded
5. Added Filter by department dropdown
6. Searching and Filtering does not redirect to other page, instead it updates the index
7. Streamlined search feature by removing redundant viewer and using HTTP get method
8. Visual front-end updates:
   1. Favicon update
   2. Navbar visuals
   3. Job cards revamp
   4. Sign in with google logo
   5. Active jobs and closed jobs layout
9. Time displays now use datetime.Now rather than today. used in precision for admin purposes
10. Add save email template feature before sending email

**Questionable changes**:

1. Delete button now deletes the job from the database
2. Time expiry can be used to disable apply button so that it may not receive application again
3. Job creation allow binding new columns and table, but entities of minEdu, location, employment type, and department don't have CUD

**TODOs**:
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

| Migration Name          | Changes Made                                                                                                                                                                                        |
|-------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Init Migration          | - Create AspNetUser-related tables<br>- Create Jobs table<br>- Create UserJobs table                                                                                                               |
| newTableCandidate Migration | - Create Candidates table                                                                                                                                             |
| updateIdentityAddUser Migration | - Remove discriminator column in AspNetUsers table<br>- Alter name column in AspNetUsers table to not nullable                                                               |
| newStatusInJob Migration | - Add StatusInJob column in UserJobs table                                                                                                                      |
| nameAllowNull Migration | - Alter name column in AspNetUsers table to be nullable                                                                                           |
| counterJob Migration    | - Remove StatusInJob column<br>- Add candidateCount column to jobs table                                                                                           |
| add-timeTableInterview Migration | - Add email interview-related columns to the userjobs table                                                                            |
| add-EmailReject Migration | - Add rejection email column to the jobs table                                                                                                              |
| Add-Salary-Candidate Migration | - Add EmailInterviewUser column to the UserJobs table                                                                                       |
| add-userInterviewerEmail Migration | - Add UserEmailInterview column to the Jobs table                                                                                 |
| add-LocationInterview Migration | - Add LocationHRInterview and LocationUserInterview columns to UserJobs table                                          |
| Cleardb Migration       | - No changes to the schema                                                                                                                                         |
| AddNewJobColumns Migration | - Add EmploymentType, JobDepartment, and JobMinEducation columns to Jobs table                                                             |
| AddDbSetForDepartment Migration | - Create new department table with relation to the jobs table                                                          |
| fixJobForeignKeyDepartment Migration | - Fixed foreign key mapping of Department in Jobs table<br>- Renamed candidateCount column to CandidateCount in Jobs table |

## 📖 Lessons Learned

## 🗺️  Future Developments