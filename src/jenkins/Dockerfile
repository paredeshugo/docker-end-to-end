FROM jenkins/jenkins:lts

EXPOSE 8080
EXPOSE 50000

COPY plugins.txt /usr/share/jenkins/ref/plugins.txt
RUN /usr/local/bin/install-plugins.sh < /usr/share/jenkins/ref/plugins.txt
