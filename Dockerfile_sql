FROM mcr.microsoft.com/mssql/server:2017-latest-ubuntu

COPY ./backup/VF_DEV_DSO.bak /var/opt/mssql/backup/VF_DEV_DSO.bak

COPY ./restore-db.sh /
RUN chmod +x /restore-db.sh

COPY docker-entrypoint.sh /
RUN chmod +x /docker-entrypoint.sh

ENTRYPOINT ["/docker-entrypoint.sh"]

CMD ["sqlservr"] 
