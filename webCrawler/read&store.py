#-*- coding: utf-8 -*-	
parse=" "
filename = "/home/zdt/Downloads/by_inst"
by_inst = open(filename)
done = 0	#end of file

def brace(l):
	elem=l[0]
	for e in l[1:]:
		if e!=' ' and e!="\n" and e!='':
			elem+=' '+e
	if elem[-1]=="\n":	#remove the newline appended,and brace
		return elem[1:-2]
	return elem[1:-1]	#remove brace


while not done:
	
	count = 0 	#get the number of element for erase the parsing of braces
	line = by_inst.readline()	#read a line and pick elements
	raw_elem=[]	#the result of parsing line
	elem=[]	#the result of removing empty and space
	
	if line[0]!='#' and line!="":
		raw_elem=line.split(parse)

		#ignore number upfront
		for e in raw_elem[1:]:
			count+=1
			#remove space,empty string and newline
			if e!=' ' and e!="\n" and e!='':
				if e[0]=="(":
					# print elem
					e=brace(raw_elem[count:])	#call brace()
					elem.append(e)
					break
				elem.append(e)
		elem[:3]
		print elem

by_inst.close()