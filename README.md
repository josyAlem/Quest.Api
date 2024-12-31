docker buildx build --tag josyalem/quest-api:v1.0.3 -f ./src/Quest.Api/Dockerfile .

docker run --name questapi -d -p 9090:8080 josyalem/quest-api:v1.0.3

http://localhost:9090/api-docs/index.html

