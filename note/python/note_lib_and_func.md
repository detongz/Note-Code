#python库和函数

##urlretrieve方法
直接将远程数据下载到本地。
>urllib.urlretrieve(url[, filename[, reporthook[, data]]])
参数说明：
url：外部或者本地url
filename：指定了保存到本地的路径（如果未指定该参数，urllib会生成一个临时文件来保存数据）；
reporthook：是一个回调函数，当连接上服务器、以及相应的数据块传输完毕的时候会触发该回调。我们可以利用这个回调函数来显示当前的下载进度。
data：指post到服务器的数据。该方法返回一个包含两个元素的元组(filename, headers)，filename表示保存到本地的路径，header表示服务器的响应头。

##PIL图形处理库初尝试
###镜像效果
```
from PIL import Image

img=Image.open('filename')
out=img.transform(Image.FLIP_LEFT_RIGHT)
out.save('path/fileout.png')
```
[参考](http://tech.seety.org/python/python_imaging.html),有较为详细的代码。

*transpose*
img.transpose(method)  
method参数:
	FLIP_LEFT_RIGHT 	左右倒置
	FLIP_TOP_BOTTOM 	上下倒置
	ROTATE_90 	旋转90度(逆时针)
	ROTATE_180 	旋转180度(逆时针)
	ROTATE_270 	旋转270度(逆时针)
