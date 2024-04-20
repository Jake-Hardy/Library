# Library API

## Running the application

- Run `docker build -t library-api .` to build the Docker image
- Run `docker run -p 127.0.0.1:8080:8080 library-api` to start the container and make the application accessible
  - Alternatively, you can add a `-d` option alongside `-p` to run the container in a detached state, but you will need to `docker stop` the container when finished
- Access the application Swagger docs at `http://localhost:8080/swagger/index.html`