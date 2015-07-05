import tornado.ioloop
import tornado.web

class MainHandler(tornado.web.RequestHandler):
	def get(self):
		self.write("hello world")
class hello(tornado.web.RequestHandler):
	def get(self):
		self.write('<html><div style = "height:20px; width:100%; color:red;font-size:50px;"></br>hello!</html>')

application = tornado.web.Application([
	(r"/",MainHandler),
	(r"/hahaha",hello),
])

if __name__ == "__main__":
	application.listen(8081)
	tornado.ioloop.IOLoop.instance().start()
