# SA53_WU-PINZE-_fibonacci

how to use dockerfile build docker image 
1. cd to dockerfile path
2. Terminal run --->  docker build -t localtestOracle:v1.2 .
3. after success build the docker image ---- > docker run -dti -p <yourport>:<dockerPort> --name <containerName> <imageName>:Version
   eg: docker run -dti -p 80:80 --name localDockertest localtestoracle:v1.2
   
   if docker run in the locallhost can use this url to access
   
4. use http://localhost:80/fibonacci?elements=12

