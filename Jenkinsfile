pipeline {
  agent any
  stages {
    stage('checkout') {
      steps {
        git(url: 'https://github.com/Nagarjunacygnet/CICD-Integration-Sitefinity.git', branch: 'master', credentialsId: 'Nagarjunacygnet')
      }
    }
  }
}