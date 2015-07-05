#-*- coding: utf-8 -*-
import MySQLdb

'''
reference 
http://stackoverflow.com/questions/372885/how-do-i-connect-to-a-mysql-database-in-python
http://www.cnblogs.com/rollenholt/archive/2012/05/29/2524327.html
'''
def db_connect(my_list):
	db = MySQLdb.connect(
		host="localhost",	#host
		user="root",	#username
		# db="courceDesign"	#name of database
		)

	#cursor object
	cur = db.cursor()
	db.select_db('ce')
	# exe='insert into popcon_debian values('+my_list[0]
	# for l in my_list[1:]:
	# 	exe+=','+l
	# exe+=');'
	# cur.execute(exe)


	# cur.execute('insert into popcon_debian values(%s,%s,%s,%s,%s,%s,%s)',my_list)
	# db.commit()
	# db.close()	