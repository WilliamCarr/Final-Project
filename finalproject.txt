/*drop table researcher;
drop table article_review;
drop table author;
drop table research_group;
drop table username;

drop table article;*/

  CREATE TABLE "ARTICLE" 
   (	"ARTICLE_ID" NUMBER(3,0)NOT NULL PRIMARY KEY, 
	"ARTICLE_NAME" VARCHAR2(200 BYTE)NOT NULL, 
	"ARTICLE_AUTHOR" VARCHAR2(50 BYTE)NOT NULL, 
	"ARTICLE_ABSTRACT" VARCHAR2(4000 BYTE)NOT NULL, 
	"DATE_PUBLISHED" VARCHAR2(20 BYTE)NOT NULL, 
	"ISSUE_NUMBER" VARCHAR2(20 BYTE), 
	"KEYWORDS" VARCHAR2(500 BYTE)NOT NULL, 
	"RESEARCHER_ID" NUMBER(3,0)
   ) ;

Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (1,'Search Quality and Revenue Cannibalization by Competing Search Engines','G Taylor','Consumers are attracted by high-quality 
search results. Search engines, though, essentially compete against themselves because consumers are induced to substitute away from 
advertisement links when their organic counterparts are of high quality. I characterize the effect of such revenue cannibalization upon 
equilibrium quality when search engines compete for clicks. Cannibalization provides an incentive for quality degradation, engendering low-quality 
equilibria—even when provision is costless. When consumers exhibit loyalty there is a ceiling above which result quality cannot rise, 
regardless of what the maximum feasible quality happens to be. Seemingly procompetitive developments may exert downward pressure on equilibrium 
quality','23 September 2013','3','search engines, Cannibalisation, equilibria',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (2,'Consistency Tradeoffs in Modern Distributed Database  Design: CAP is Only Part of the Story','D Abadi','The CAP theorems impact on modern distributed database  design is more limited than is often perceived. Another tradeoff—between consistency ','23 February 2012','02','Usability, Information, Query, Report',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (3,'TIIS: A two-level inverted-index scheme for large-scale data processing in the parallel database ','L Yu ','Based on Service-Oriented Architecture, an inexpensive solution, Parallel database middleware gather the standalone database instance to provide
users with highly scalable relational data management platform. However, with the advent of the era of large-scale data, such platform has posed a 
serious challenge in the context of text data retrieval. Motivated by this observation, a parallel database middleware based on semi-structure data
is firstly designed to support text retrieval. Then, a two-level inverted-index scheme called TIIS is designed for full-text query. The advantages of
TIIS are that it can quickly locate the result data from large cluster distributed database storing large-scale data, and it can greatly reduce the network 
I/O and disk I/O. Experimental results show that, comparing with Hive using Hadoop Distributed File  in same environment of hardware, our  performs 
typical TPC-H data analysis, consuming of full-text query is declined by 90% on 2GB commercial data in average','22 Dec. 2013','6885464','data analysis;database indexing;middleware;parallel databases;query processing;text analysis;Hadoop distributed file ',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (4,'Highly scalable algorithm for distributed real-time text indexing','A Narang','Stream computing research is moving from terascale to petascale levels. 
It aims to rapidly analyze data as it streams in from many sources and make decisions with high speed and accuracy in fields as diverse as security surveillance and financial services 
including stock trading. We specifically consider real-time text indexing and search with high input data rates (10 GB/s or more) along with small indexage-off (expiry) time. This makes 
it necessary to have maximal indexing rates for large volumes of data as well as minimal latency for indexing (time between start of indexing for a document and its availability for search) 
while maintaining very-low search response time. In addition, future massively parallel architectures with storage class memories will enable high speed in-memory real-time indexing, whereindex 
can be completely stored in a high capacity storage class memory. In this paper, we present the design of distributed data-structures and distributed real-time text indexing algorithm for parallel 
s having large (thousands to hundred thousand) number of cores/processors, while simultaneously providing acceptable search performance [1]. The inherent trade-offs involved in indexspace, indexing 
throughput and search response time make this problem particularly challenging. Our algorithm uses group-based index construction and leverages novel index data structures that reduce load imbalance and 
make text indexing and merge process more scalable and efficient. We show analytically that the asymptotic parallel time complexity of our distributed indexing algorithm, is at least ?(log(P)) factor
better than typical indexing approaches, where P is the number of indexing nodes in a group. We further demonstrate the performance and scalability of our distributed indexing algorithm, on an MPP 
architecture (Blue Gene/L) using actual IBM intranet data. We achieved high indexingthroughput of around 312 GB/min on an 8 K node Blue Gene/L machine. In comparison wit- h parallelindexing implemented
using typical approaches like CLucene, this is 3?-7? better. To the best of our knowledge, this is the first published result on indexing throughput at such a large scale, with sustained search performance.
We further show that our approach is scalable to 128 K nodes, giving an estimated indexing throughput of 5 T B/min. We also achieved indexing latency that is around 10? better than typical indexing approaches','19 Dec. 2009','978-1-4244-4921-7','computational complexity, data analysis, data structures, distributed algorithms indexing, merging, parallel processing , text analysis.',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (5,'Flat indexing: a compilation technique to enhance parallelism of logic programs','H Kim','The paper presents a atic approach to the compilation of logic programs for efficient 
clause indexing. As the kernel of the approach, we propose the indexing tree which provides a simple, but precise representation of average parallelism per node (i.e., choice point) as well as the amount of clause trials.
It also provides the way to evaluate the number of the cases that the control is passed to the failure code by the indexing instruction such as switch on term, switch on constant, or switch on structure. By analyzing the
indexing tree created when using the indexing scheme implemented in the WAM, we show the drawback of the WAM indexing scheme in terms of parallelism exposition and scheduling. Subsequently we propose a new indexing scheme, 
which we call Flat indexing. Experimental results show that over one half of the benchmarks benefit from the Flat indexing, such that compared with the WAM indexing scheme, the number of choice points is reduced by 15%. Moreover, 
the amount of failures which occur during the execution of indexing instructions is reduced by 35%','16 Dec 1998','1521-9097','logic programming;parallel programming;program compilers;tree data structures;
trees (mathematics);WAM indexing scheme;Warren Abstract Machine;average parallelism;clause indexing;clause trials;compilation technique;failure code;flat indexing',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (6,'MIWD: Multidimensional indexing for web documents','D Sotoude','Search engines use indexes for fast accessing data in order 
to answer user queries. Data can be web documents, pictures, spatial data, etc. Usually, inverted indexing is used to index web documents. In this 
paper, we introduce a new indexing method for web documents using multidimensional indexing approach named MIWD. First, we describe inverted indexing,
two compression methods and a traditional indexing method for spatial data objects. Then, a new indexing method and its distributed version based on 
spatial data indexing for web documents are introduced. It distributes document indexes in many machines to make our method fast and scalable. At the end, 
we compare our results for insertion and retrieving web documents with traditional indexing methods.','3 May 2012','978-1-4673-1478-7','Internet;data 
compression;document handling;indexing;information retrieval;search engines;visual databases;MIWD;Web documents;compression methods;inverted indexing;
multidimensional indexing approach',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (7,'Supporting Queries and Analyses of Large-Scale Social Media Data with Customizable and Scalable Indexing Techniques over NoSQL Databases','G Xiaoming ','Social media data analysis demonstrates two special characteristics in Big Data processing. First, most analyses focus on data subsets related
to specific social events or activities instead of the whole dataset. Second, analysis workflows consist of multiple stages, and algorithms applied in each stage 
may use different computation and communication patterns depending on processing frameworks. This paper presents our efforts in supporting the data storage and 
processing requirements for such characteristics. To achieve efficient queries about target data subsets, we propose a general customizable and scalable indexing 
framework that can be built over distributed NoSQL databases. This framework allows users to define suitable customized index structures for their query patterns 
against social media data, and supports scalable indexing of both historical and streaming data. We implement this framework on HBase, and name it IndexedHBase. 
Starting from IndexedHBase, we build a distributed analysis stack based on YARN to support analysis algorithms using different processing frameworks, such as Hadoop
MapReduce, Harp, and Giraph. This analysis stack is used to host the Truthy social media data observatory, and we have applied the customized index structures 
in supporting both query evaluation and sophisticated analysis algorithms. Performance tests show that our solutions outperform implementations using both direct
raw data scans and current indexing mechanisms in existing NoSQL databases.','29 May 2014','1673-6098','Big Data;SQL;data analysis;indexing;query processing;social 
networking (online);storage management;Big Data processing;Giraph;Hadoop MapReduce;Harp;Truthy social media data observatory;YARN',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (8,'Indexing positively constructed formulas','A Larionov','The calculus of positively constructed formulas (PCF) is a first-order formalism 
that has many features useful for solving problems of dynamic s control. For investigation of this formalism, analysis of logical inference of formulas is used.
The logical inference consist of many PCF. The analysis of big amount of formulas require special operations: search of formulas, search by template, unification search 
etc. Usually for solving these problems the indexing methods are used. For indexing terms as a tree-like structures the methods of indexing such as path indexing, 
substitution tree indexing, discrimination tree indexing etc., are used. This methods well used in many logical s. Since PCF, like a term, have a tree-like structure,
the generalization of indexing methods to the PCF indexing is possible. In this paper, we consider this problem. The modification of indexing methods and experiments 
concerning the analysis of logical inferences (big sets of PCF) are presented.','24 May 2013','978-953-233-076-2','indexing;inference mechanisms;
logic programming languages;tree data structures;PCF;dynamic  control;indexing method;logical inference;logical ;positively constructed formula;
tree-like structure;Artificial intelligence;Calculus;Cognition;Indexing;Search problems;Semantics;Testing',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (9,'Analysis of Joins and Semi-joins in Centralized and Distributed Database Queries','M Sharma','Database is defined as collection of files or table, ','15 Sept. 2012','978-1-4673-2647-6','needs updating',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (10,'High Performance Database Processing','A Taniar','The sizes of databases have seen exponential growth in the past, and such growth is expected
to accelerate in the future, with the steady drop in storage cost accompanied by a rapid increase in storage capacity. Many years ago, a terabyte database was considered
to be large, but nowadays they are sometimes regarded as small, and the daily volumes of data being added to some databases are measured in terabytes. In the future, 
petabyte and exabyte databases will be common. With such volumes of data, it is evident that the sequential processing paradigm will be unable to cope, for example,
even assuming a data rate of 1 terabyte per second, reading through a petabyte database will take over 10 days. To effectively manage such volumes of data, it is 
necessary to allocate multiple resources to it, very often massively so. The processing of databases of such astronomical proportions requires an understanding of 
how high-performance s and parallelism work. Besides the massive volume of data in the database to be processed, some data has been distributed across the 
globe in a Grid environment. These massive data centres are also a part of the emergence of Cloud computing, where data access has shifted from local machines to 
powerful servers hosting web applications and services, making data access across the Internet using standard web browsers pervasive. This adds another dimension 
to such s. This talk, based on our recent published book [1], discusses fundamental understanding of parallelism in data-intensive applications, and 
demonstrates how to develop faster capabilities to support them. This includes the importance of indexing in parallel s [2-4], specialized algorithms 
to support various query processing [5-9], as well as objectoriented scheme [10-12].','29 March 2012','1550-445X','data partitioning grid, 
databases parallel, databases parallel, query processing',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (11,'Object Deputy Database Language','Z Boxuani','Object deputy model can provide more flexibility than traditional object-oriented 
data model. Based on it, we have developed a database management  called TOTEM. In this paper, we introduce the object deputy database languages 
including object deputy definition language, object deputy manipulation language and object deputy query language, which are designed in the style of SQL','27 Jan. 2006','0-7695-2563-6','Object Deputy Model, database language',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (12,'Organizing a network of databases using probabilistic reasoning','M Shyu','Due to the complexity of real-world applications, 
the number of databases and the volumes of data in databases have increased tremendously. With the explosive growth in the amount and complexity of data, 
how to effectively organize the databases and utilize the huge amount of data becomes important. For this purpose, a probabilistic network that organizes
a network of databases and manages the data in the databases is proposed. Each database is represented as a node in the probabilistic network and the
affinity relations of the databases are embedded in the proposed Markov model mediator (MMM) mechanism. Probabilistic reasoning is used to formulate 
and derive the probability distributions for an MMM. Once the probability distributions of each MMM are generated, a stochastic process is conducted
to calculate the similarity measures for pairs of databases. The similarity measures are transformed into the branch probabilities of the probabilistic 
network. Then, the data in the database can be managed and utilized to allow user queries for database searching and information retrieval. An example
is included to illustrate how to model each database into an MMM and how to organize the network of databases into a probabilistic network','11 Oct 2000','1062-922X','Markov processes;database theory;distributed databases;uncertainty handling;Markov model mediator;branch probabilities;database searching;
information retrieval;network of databases;probabilistic network;probabilistic reasoning;probability distributions;real-world applications;similarity 
measures;stochastic process;user queries;Context modeling;Data engineering;Hidden Markov models;Information retrieval;',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (13,'Database Technology in Network Document Management ','Z Deng-Hong','In order to descript how Database Technology 
can be used in Network Document Management , this paper analyses the requirement of the , and then, the paper descript the detail from 
these aspects: database design, security design and database optimization. Firstly, the paper shows how we can design the data storage method and 
the database of network document management  so that the design can meet the requirement, then, the paper descript three way to optimization 
the database: data table partition, primary key design and index selection, data query optimization is also introduced. At the end of the paper,
database security design, a very important aspect of our application, is decrypted. In a word, this paper shows almost every aspect of database 
we should take care in a network document management .','9 Nov. 2010','978-1-4244-7159-1','collections of physical data;cryptography;database
indexing;document handling;optimisation;query processing;data query optimization;data storage',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (14,'Database management with sequence trees and tokens','R.C. Goldstein','An approach to organizing storage in database 
s is presented that, under a wide range of conditions, saves both storage space and processing time. Text values in a database are 
replaced by short, fixed-length, rank-preserving numeric tokens. The actual values are stored in separate, non-redundant storage. Database 
operations that depend only on the relative magnitude of data values can be performed directly on the tokens. Tokenization is shown to 
improve database performance most in situations where there are a lot of ad hoc queries and a low volume of database insertions relative 
to other operations','06 August 2002','1041-4347','abstract data types, database management s, database theory, query processing,
sequences, software performance evaluation, tree data structures',null);
Insert into ARTICLE (ARTICLE_ID,ARTICLE_NAME,ARTICLE_AUTHOR,ARTICLE_ABSTRACT,DATE_PUBLISHED,ISSUE_NUMBER,KEYWORDS,RESEARCHER_ID) values (15,'OncoPET_DB: A Freely Distributed Database of Realistic Simulated Whole Body 18F-FDG PET Images for Oncology','S Tomei','The purpose of this paper is to generate and distribute a database of simulated whole body 18F-FDG positron emission tomography (PET) oncology
images. As far as we know, this database is the first addressing the need for simulated 18F-FDG PET oncology images by providing a series of 
realistic whole-body patient images with well-controlled inserted lesions of calibrated uptakes. It also fulfills the requirements of detection 
performance studies by including normal and pathological cases. The originality of the database is based on three points. First, we built a 
complex model of 18F-FDG patient based on the Zubal phantom in combination with activity distributions in the main organs of interest derived
from a series of 70 clinical cases. Secondly, we proposed a model of lesions extent corresponding to real lymphoma patients. The lesion contrast
levels were derived from a human observer detection study so as to cover the entire range of detectability. Lastly, the simulated database
was generated with the PET-SORTEO Monte Carlo simulation tool that was fully validated against the geometry of the ECAT EXACT HR+ 
(CTI/Siemens Knoxville). The oncoPET_DB database is composed of 100 whole-body PET simulated images, including 50 normal cases coming from different 
realizations of noise of the healthy model and 50 pathological cases including lesions of calibrated uptakes and various diameters. Such a database
will be useful to evaluate algorithms that may impact quantification or contrast recovery, to perform observer studies or to assess computer-aided
diagnosis methods. Perspectives include enriching the present database with new pathological and normal cases accounting for interindividual 
variability of anatomy and FDG uptake.','08 February 2010','0018-9499','Database, Monte Carlo simulation ,oncology ,positron emission tomography (PET)',null);



  CREATE TABLE 
  "ARTICLE_REVIEW" 
   (	"REVIEW_ID" NUMBER(3,0)PRIMARY KEY NOT NULL, 
	"REVIEW_SCORE" VARCHAR2(20 BYTE)NOT NULL, 
	"REVIEW_DESCRIPTION" VARCHAR2(20 BYTE)NOT NULL, 
	"ARTICLE_ID" NUMBER(3,0), 
	"RESEARCHER_ID" NUMBER(3,0)
   ) ;
   
   
  CREATE TABLE "AUTHOR" 
   (	"AUTHOR_ID" NUMBER(3,0)NOT NULL PRIMARY KEY, 
	"AUTHOR_FIRST_NAME_INITIAL" VARCHAR2(1 BYTE)NOT NULL, 
	"AUTHOR_SURNAME" VARCHAR2(30 BYTE)NOT NULL, 
	"ARTICLE_ID" NUMBER(3,0)
   )  ;

Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (1,'G','Taylor',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (2,'D','Abjadi',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (3,'L','Yu',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (4,'A','Narang',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (5,'H','Kim',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (6,'D','Sototude',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (7,'G','Xiaoming ',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (8,'A','Larionov',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (9,'M','Sharma',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (10,'A','Taniar',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (11,'Z','Boxuani',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (12,'M','Shyu',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (13,'Z','Deng-Hong',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (14,'R','Goldstein',null);
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FIRST_NAME_INITIAL,AUTHOR_SURNAME,ARTICLE_ID) values (15,'S','Tomei',null);

  CREATE TABLE "RESEARCH_GROUP" 
   (	"RESEARCH_GROUP_ID" NUMBER (3,0)NOT NULL PRIMARY KEY ,
	"RESEARCH_GROUP_NAME" VARCHAR2(100 BYTE)NOT NULL, 
	"RESEARCHER_ID" NUMBER(3,0)
   );

Insert into RESEARCH_GROUP (RESEARCH_GROUP_ID,RESEARCH_GROUP_NAME,RESEARCHER_ID) values (1,'Logic and Computation',null);
Insert into RESEARCH_GROUP (RESEARCH_GROUP_ID,RESEARCH_GROUP_NAME,RESEARCHER_ID) values (2,'Intelligent s',null);
Insert into RESEARCH_GROUP (RESEARCH_GROUP_ID,RESEARCH_GROUP_NAME,RESEARCHER_ID) values (3,'Image and Sensory Computation',null);
Insert into RESEARCH_GROUP (RESEARCH_GROUP_ID,RESEARCH_GROUP_NAME,RESEARCHER_ID) values (4,'Future Networks and Distributed s',null);


  CREATE TABLE "RESEARCHER" 
   (	"RESEARCHER_ID" NUMBER(3,0)NOT NULL PRIMARY KEY, 
	"RESEARCHER_FIRST_NAME" VARCHAR2(50 BYTE)NOT NULL, 
	"RESEARCHER_SURNAME" VARCHAR2(100 BYTE)NOT NULL, 
	"RESEARCHER_ROLE" VARCHAR2(200 BYTE)NOT NULL, 
	"RESEARCHER_EMAIL" VARCHAR2(100 BYTE)NOT NULL, 
	"RESEARCHER_PHONE_NUMBER" VARCHAR2(25 BYTE)
   ) ;
Insert into RESEARCHER (RESEARCHER_ID,RESEARCHER_FIRST_NAME,RESEARCHER_SURNAME,RESEARCHER_ROLE,RESEARCHER_EMAIL,RESEARCHER_PHONE_NUMBER) values (1,'Fred','Cook','Logic and Computation','FredCook@mmu.ac.uk','0782123643');
Insert into RESEARCHER (RESEARCHER_ID,RESEARCHER_FIRST_NAME,RESEARCHER_SURNAME,RESEARCHER_ROLE,RESEARCHER_EMAIL,RESEARCHER_PHONE_NUMBER) values (2,'Aaron','Hill','Logic and Computation','AaronHill@mmu.ac.uk','07823554324');
Insert into RESEARCHER (RESEARCHER_ID,RESEARCHER_FIRST_NAME,RESEARCHER_SURNAME,RESEARCHER_ROLE,RESEARCHER_EMAIL,RESEARCHER_PHONE_NUMBER) values (3,'Henry','White','Intelligent s','HenryWhite@mmu.ac.uk','07334242424');
Insert into RESEARCHER (RESEARCHER_ID,RESEARCHER_FIRST_NAME,RESEARCHER_SURNAME,RESEARCHER_ROLE,RESEARCHER_EMAIL,RESEARCHER_PHONE_NUMBER) values (4,'Martin','Jackson','Logic and Computation','MartinJackson@mmu.ac.uk','07252253414');
Insert into RESEARCHER (RESEARCHER_ID,RESEARCHER_FIRST_NAME,RESEARCHER_SURNAME,RESEARCHER_ROLE,RESEARCHER_EMAIL,RESEARCHER_PHONE_NUMBER) values (5,'Albert','Green','Intelligent s','AlbertGreen@mmu.ac.uk','07856385665');
Insert into RESEARCHER (RESEARCHER_ID,RESEARCHER_FIRST_NAME,RESEARCHER_SURNAME,RESEARCHER_ROLE,RESEARCHER_EMAIL,RESEARCHER_PHONE_NUMBER) values (6,'Jane','Harris','Image and Sensory Computation','JaneHarris@mmu.ac.uk','07478356298');
Insert into RESEARCHER (RESEARCHER_ID,RESEARCHER_FIRST_NAME,RESEARCHER_SURNAME,RESEARCHER_ROLE,RESEARCHER_EMAIL,RESEARCHER_PHONE_NUMBER) values (7,'Harriet','Ross','Logic and Computation','HarrietRoss@mmu.ac.uk','07224543321');
Insert into RESEARCHER (RESEARCHER_ID,RESEARCHER_FIRST_NAME,RESEARCHER_SURNAME,RESEARCHER_ROLE,RESEARCHER_EMAIL,RESEARCHER_PHONE_NUMBER) values (8,'Ralph','Campbell','Intelligent s','RalphCampbell@mmu.ac.uk','07112843753');
Insert into RESEARCHER (RESEARCHER_ID,RESEARCHER_FIRST_NAME,RESEARCHER_SURNAME,RESEARCHER_ROLE,RESEARCHER_EMAIL,RESEARCHER_PHONE_NUMBER) values (9,'Lawrence','Bell','Future Networks and Distributed s','LawrenceBell@mmu.ac.uk','07836945174');
Insert into RESEARCHER (RESEARCHER_ID,RESEARCHER_FIRST_NAME,RESEARCHER_SURNAME,RESEARCHER_ROLE,RESEARCHER_EMAIL,RESEARCHER_PHONE_NUMBER) values (10,'Diane','King','Future Networks and Distributed s','DianeKing@mmu.ac.uk','0783582645');


  CREATE TABLE "USERNAME" 
   (	"USERNAME_ID" NUMBER(3,0)NOT NULL PRIMARY KEY, 
	"USERNAME" VARCHAR2(50 BYTE)NOT NULL, 
	"PASSWORD" VARCHAR2(20 BYTE)NOT NULL, 
	"USER_FULL_NAME" VARCHAR2(100 BYTE)NOT NULL, 
	"RESEARCHER_ID" NUMBER(3,0)
   ) ;
Insert into USERNAME (USERNAME_ID,USERNAME,PASSWORD,USER_FULL_NAME,RESEARCHER_ID) values (1,'12822816','password1','Fred Cook',null);
Insert into USERNAME (USERNAME_ID,USERNAME,PASSWORD,USER_FULL_NAME,RESEARCHER_ID) values (2,'13272615','Password2','Aaron Hill',null);
Insert into USERNAME (USERNAME_ID,USERNAME,PASSWORD,USER_FULL_NAME,RESEARCHER_ID) values (3,'13285947','password3','Henry White',null);
Insert into USERNAME (USERNAME_ID,USERNAME,PASSWORD,USER_FULL_NAME,RESEARCHER_ID) values (4,'12245674','password4','Martin Jackson',null);
Insert into USERNAME (USERNAME_ID,USERNAME,PASSWORD,USER_FULL_NAME,RESEARCHER_ID) values (5,'13453434','password5','Albert Green',null);
Insert into USERNAME (USERNAME_ID,USERNAME,PASSWORD,USER_FULL_NAME,RESEARCHER_ID) values (6,'12545454','password6','Jane Harris',null);
Insert into USERNAME (USERNAME_ID,USERNAME,PASSWORD,USER_FULL_NAME,RESEARCHER_ID) values (7,'12334356','password7','Harriet Ross',null);
Insert into USERNAME (USERNAME_ID,USERNAME,PASSWORD,USER_FULL_NAME,RESEARCHER_ID) values (8,'11232443','password8','Ralph Campbell',null);
Insert into USERNAME (USERNAME_ID,USERNAME,PASSWORD,USER_FULL_NAME,RESEARCHER_ID) values (9,'13423424','password9','Lawrence Bell',null);
Insert into USERNAME (USERNAME_ID,USERNAME,PASSWORD,USER_FULL_NAME,RESEARCHER_ID) values (10,'12334733','password10','Diane King',null);


ALTER TABLE Article_Review
ADD CONSTRAINT fk_articleId1
FOREIGN KEY(Article_ID)
REFERENCES Article(Article_ID); 

ALTER TABLE Article
ADD CONSTRAINT fk_ReasearchId1
FOREIGN KEY(RESEARCHER_ID)
REFERENCES RESEARCHER(RESEARCHER_ID);

ALTER TABLE Research_group
ADD CONSTRAINT fk_ReasearchId2
FOREIGN KEY(RESEARCHER_ID)
REFERENCES RESEARCHER(RESEARCHER_ID);

ALTER TABLE Username
ADD CONSTRAINT fk_ReasearchId3
FOREIGN KEY(RESEARCHER_ID)
REFERENCES RESEARCHER(RESEARCHER_ID);

ALTER TABLE Article_review
ADD CONSTRAINT fk_ReasearchId4
FOREIGN KEY(RESEARCHER_ID)
REFERENCES RESEARCHER(RESEARCHER_ID);


