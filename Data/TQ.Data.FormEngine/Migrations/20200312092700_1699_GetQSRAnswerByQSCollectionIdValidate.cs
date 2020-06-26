﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace TQ.Data.FormEngine.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class _1699_GetQSRAnswerByQSCollectionIdValidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var strGetQuestionSetbyIdProc = @"CREATE PROCEDURE [dbo].[GetQSRAnswerByQSCollectionIdValidate]
                @QSCollectionId  UNIQUEIDENTIFIER 
                AS 
                BEGIN
                SELECT tempField.fieldid, 
                       fieldno, 
                       QSRAnswerId, 
                       QSRID, 
                       Answer, 
                       FieldType, 
                       display, 
                       displayconstraint, 
                       constraintrule, 
                       constraintrulecount, 
                       answerrule, 
                       answerrulecount, 
                       answertype, 
                       errlabel, 
                	   [Min],
                	   [Max],
					   Regex,
                       fieldcount, 
                       FieldAnswerMatchCount 
                FROM   (SELECT DISTINCT fields.fieldid, 
                                        fields.fieldno, 
                                        qsranswerid, 
                                        qsr.qsrid, 
                                        answer, 
                                        (SELECT fieldtypes 
                                         FROM   [Forms].fieldtypes FT 
                                         WHERE  FT.fieldtypeid = fields.fieldtypeid)         AS 
                                               FieldType, 
                                        (SELECT displays 
                                         FROM   [Forms].displays 
                                         WHERE  displays.displayid = fields.displayid)       AS 
                                        Display 
                                               , 
                                        (SELECT[constraints] 
                                         FROM   [Forms].constraints C 
                                         WHERE  C.constraintid = fields.displayconstraintid) AS 
                                               DisplayConstraint, 
                                        (SELECT[rules] 
                                         FROM   [Forms].rules R 
                                         WHERE  R.ruleid = fields.constraintruleid)          AS 
                                               ConstraintRule, 
                                        fields.constraintrulecount, 
                                        (SELECT [rules] 
                                         FROM   [Forms].rules RU 
                                         WHERE  RU.ruleid = fields.answerruleid)             AS 
                                               AnswerRule, 
                                        fields.answerrulecount, 
                                        (SELECT TOP 1 answertypes 
                                         FROM   [Forms].answertypes 
                                         WHERE  answertypes.answertypeid = AG.answertypeid)  AS 
                                               AnswerType, 
                                        errlabel ,
                						[Min],
                						[Max],
										(SELECT CASE WHEN AG.AnswerTypeId = 4 then [value] else null END ) as Regex
                        FROM   [Sessions].qscollections QSC 
                               INNER JOIN [Sessions].qsr 
                                       ON QSC.qscollectionid = qsr.qscollectionid 
                               INNER JOIN [Forms].qssectionmappings QSM 
                                       ON qsr.qsid = QSM.qsid 
                               INNER JOIN [Forms].sectionfieldmappings SFM 
                                       ON QSM.sectionid = SFM.sectionid 
                               INNER JOIN [Forms].fields 
                                       ON SFM.fieldid = fields.fieldid 
                               LEFT JOIN [Sessions].qsranswers QSRA 
                                      ON fields.fieldid = QSRA.fieldid 
                                         AND qsr.qsrid = QSRA.qsrid 
                               LEFT JOIN [Forms].answerguides AG 
                                      ON fields.fieldid = AG.fieldid 
                					  AND ag.AnswerTypeId <> 3
                        WHERE  QSC.qscollectionid = @QSCollectionId) AS tempField 
                       LEFT JOIN (SELECT fieldid, 
                                         Count(fieldid) AS fieldcount, 
                                         Sum(CASE 
                                               WHEN answer = [value] AND Answer IS NOT NULL THEN 1 
                                               ELSE 0 
                                             END)       AS FieldAnswerMatchCount 
                                  FROM   (SELECT DISTINCT FCI.fieldid, 
                                                          answer, 
                                                          QSA.qsrid, 
                                                          FAG.fieldid AS dependentfield, 
                                                          FAG.value 
                                          FROM   forms.fieldconstraints FCI 
                                                 INNER JOIN forms.sectionfieldmappings SFM 
                                                         ON FCI.fieldid = SFM.fieldid 
                                                 INNER JOIN forms.qssectionmappings QSSM 
                                                         ON SFM.sectionid = QSSM.sectionid 
                                                 INNER JOIN sessions.qsr 
                                                         ON QSSM.qsid = qsr.qsid 
                										 AND Qsr.QSCollectionId=@QSCollectionId
                                                 LEFT JOIN forms.answerguides FAG 
                                                        ON 
                                                 FCI.dependantanswerguideid = FAG.answerguideid 
                                                 LEFT JOIN sessions.qsranswers QSA 
                                                        ON FAG.fieldid = QSA.fieldid 
                                                           AND Qsr.QsrId = QSA.qsrid                         
                                         ) AS 
                                         FieldConstr 
                                  GROUP  BY fieldid) AS tempFieldConst 
                              ON tempField.fieldid = tempFieldConst.fieldid 


	-- Table 2 to get all answertype value for validating
		SELECT Fields.FieldId
		,AnswerGuideId 
		,[Value]  
		FROM    [Sessions].qsr                                       
                INNER JOIN [Forms].QSSectionMappings QSM 
                       ON qsr.qsid = QSM.qsid 
                 INNER JOIN [Forms].sectionfieldmappings SFM 
                        ON QSM.sectionid = SFM.sectionid 
                 INNER JOIN [Forms].Fields 
                       ON SFM.FieldId = Fields.FieldId                              
                 LEFT JOIN [Forms].AnswerGuides AG 
                        ON Fields.FieldId = AG.FieldId                 					 
		WHERE  qsr.qscollectionid = @QSCollectionId
		AND AG.AnswerTypeId=6
									   
            END";
            strGetQuestionSetbyIdProc = strGetQuestionSetbyIdProc.Replace("'", "''");
            migrationBuilder.Sql($"EXEC ('{strGetQuestionSetbyIdProc}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var strGetQuestionSetbyIdProc = "DROP PROCEDURE [dbo].[GetQSRAnswerByQSCollectionIdValidate];";
            strGetQuestionSetbyIdProc = strGetQuestionSetbyIdProc.Replace("'", "''");
            migrationBuilder.Sql($"EXEC ('{strGetQuestionSetbyIdProc}')");
        }
    }
}