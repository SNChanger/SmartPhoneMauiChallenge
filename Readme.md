#���̃v���W�F�N�g�ɂ���

Spajam�ł݂�Ȃ��X�}�z�A�v����i�߂Ă����������Ă݂���B

## �Z�p�\��

### �J����

VisualStudio2022�Ή�

### �e�y�[�W�̍쐬

.Net MAUI�̃e���v���[�g�t�@�C�����g���č쐬

### �����쐬���̎Q�l����

https://github.blog/2022-02-14-include-diagrams-markdown-files-mermaid/

### ���j���[��ʂ̍ŏI�I�ȑJ��(ReleasePlan LastFlow)
```mermaid
flowchart LR
    subgraph App
        subgraph Menu
           userMemoTab -->userMemoDetail
           itemListTab -->itemList
           facilitySearchTab -->facilitySearchDisplay
           medicinedinputFormTab --> medicinedinputForm
        end
    end
User --> App --> Display
```
#### �e��ʂ̎����\����e
##### �ߋ��̎�f���e�ꗗ
##### ��ʑ��T�v
���͉�ʂŕۑ��������e�̎�f�����ꗗ��\������
��f�������N���b�N���邱�Ƃŏڍ׉�ʂ֑J�ڂ���
##### �f�[�^�J��
```mermaid
sequenceDiagram
    participant �C�x���g���v���O����
    participant ����ꗗ�擾
    participant �ۑ���
    �C�x���g���v���O����->>����ꗗ�擾: �w�肵���A�J�E���g�̎�f���ʈꗗ�擾���Ăяo��
    ����ꗗ�擾->>�ۑ���: �w�肵���A�J�E���g�̎�f���ʈꗗ�擾���߂����s
    �ۑ���->>����ꗗ�擾: �w�肵���A�J�E���g�̎�f���ʈꗗ�擾���߂̎��s���ʂ�ԋp
    ����ꗗ�擾->>�C�x���g���v���O����: �w�肵���A�J�E���g�̎�f���ʈꗗ�擾���ʂ�ԋp
    loop �P�y�[�W�ɕ\������f�[�^��
    �C�x���g���v���O����->>�C�x���g���v���O����: �擾�����ꗗ�ɂ��āAXAML���ɔ��f����
    end
```


