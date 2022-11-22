
FROM node:alpine

WORKDIR /app

EXPOSE 3000

ENV PATH /app/node_modules/.bin:$PATH

COPY package.json ./
COPY package-lock.json ./
RUN npm i

COPY . ./

CMD ["npm", "run", "start"]