SELECT student_id, exam_id, score
FROM exam_results e1
WHERE score = (
    SELECT MAX(score) 
    FROM exam_results e2 
    WHERE e2.student_id = e1.student_id
)
AND exam_id = (
    SELECT MIN(exam_id)
    FROM exam_results e3
    WHERE e3.student_id = e1.student_id
    AND e3.score = e1.score
)
ORDER BY student_id;
